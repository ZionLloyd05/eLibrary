using eLibrary.ApplicationCore.Interfaces;
using eLibrary.ApplicationCore.Specifications;
using eLibrary.UI.Models.Patron;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.UI.Controllers
{
    public class PatronController : Controller
    {
        private readonly IPatron _patron;

        public PatronController(IPatron patron)
        {
            _patron = patron;
        }

        public async Task<IActionResult> Index()
        {
            var spec = new PatronsWithCardAndBranchSpecification();
            var allPatrons = await _patron.ListAsync(spec);

            var patronModels = allPatrons
                .Select(p => new PatronDetailModel
                {
                    Id = p.Id,
                    LastName = p.LastName ?? "No First Name Provided",
                    FirstName = p.FirstName ?? "No Last Name Provided",
                    LibraryCardId = p.LibraryCard?.Id,
                    OverdueFees = p.LibraryCard?.Fees,
                    HomeLibrary = p.HomeLibraryBranch?.Name
                });

            return View(patronModels);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var spec = new PatronWithCardAndBranchSpecification(id);
            var patronResult = await _patron.ListAsync(spec);

            var patron = patronResult
                .FirstOrDefault(ptrn => ptrn.Id == id);

            var patronModel = new PatronDetailModel
            {
                Id = patron.Id,
                LastName = patron.LastName ?? "No Last Name Provided",
                FirstName = patron.FirstName ?? "No First Name Provided",
                Address = patron.Address.Street ?? "No Address Provided",
                HomeLibrary = patron.HomeLibraryBranch?.Name ?? "No Home Library",
                MemberSince = patron.LibraryCard?.Created,
                OverdueFees = patron.LibraryCard?.Fees,
                LibraryCardId = patron.LibraryCard?.Id,
                Telephone = string.IsNullOrEmpty(patron.TelephoneNumber) ? "No Telephone Number Provided" : patron.TelephoneNumber,
                AssetsCheckedOut = _patron.GetCheckouts(id),
                CheckoutHistory = _patron.GetCheckoutHistory(id),
                Holds = _patron.GetHolds(id).ToList()
            };

            return View(patronModel);
        }
    }
}
