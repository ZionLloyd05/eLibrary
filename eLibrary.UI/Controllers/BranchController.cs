using eLibrary.ApplicationCore.Interfaces;
using eLibrary.ApplicationCore.Specifications;
using eLibrary.UI.Models.Branch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.UI.Controllers
{
    public class BranchController : Controller
    {
        private readonly ILibraryBranch _branch;

        public BranchController(ILibraryBranch branch)
        {
            _branch = branch;
        }

        public async Task<IActionResult> Index()
        {
            var spec = new LibraryBranchesWithPatronAndAssetsSpecification();
            var allBranches = await _branch.ListAsync(spec);

            var branchModels = allBranches
                .Select(branch => new BranchDetailModel
                {
                    Id = branch.Id,
                    BranchName = branch.Name,
                    NumberOfAssets = _branch.GetAssetCount(branch.Id),
                    NumberOfPatrons = _branch.GetPatronCount(branch.Id),
                    IsOpen = _branch.IsBranchOpen(branch.Id)
                });

            var model = new BranchIndexModel()
            {
                Branches = branchModels
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var spec = new LibraryBranchWithPatronAndAssetsSpecification(id);
            var branchResult = await _branch.ListAsync(spec);

            var branch = branchResult
                .FirstOrDefault(brch => brch.Id == id);

            var branchModel = new BranchDetailModel
            {
                BranchName = branch.Name,
                Description = branch.Description,
                Address = branch.Address,
                Telephone = branch.Telephone,
                BranchOpenedDate = branch.OpenDate.ToString("yyyy-MM-dd"),
                NumberOfPatrons = _branch.GetPatronCount(id),
                NumberOfAssets = _branch.GetAssetCount(id),
                TotalAssetValue = _branch.GetAssetsValue(id),
                ImageUrl = branch.ImageUrl,
                HoursOpen = _branch.GetBranchHours(id)
            };

            return View(branchModel);
        }
    }
}
