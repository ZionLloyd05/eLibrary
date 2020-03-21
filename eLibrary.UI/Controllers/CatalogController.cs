using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.ApplicationCore.Specifications;
using eLibrary.UI.Models;
using eLibrary.UI.Models.Catalog;
using eLibrary.UI.Models.Checkout;
using Microsoft.AspNetCore.Mvc;

namespace eLibrary.UI.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IAsyncLibraryAssetRepository _assets;
        private readonly ICheckout _checkout;

        public CatalogController(
            IAsyncLibraryAssetRepository assets,
            ICheckout checkout
            )
        {
            _assets = assets;
            _checkout = checkout;
        }

        public async Task<IActionResult> Index()
        {
            var assetModels = await _assets.ListAllAsync();

            var listingResult = assetModels
                .Select(result => new AssetsIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                    Title = result.Title,
                    Type = _assets.GetType(result.Id)
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var assetResult = await _assets.ListAsync(new LibraryAssetWithLocationAndStatus(id));
            var asset = assetResult.FirstOrDefault(a => a.Id == id);

            if (asset == null)
            {
                return View(null);
            };

            var currentHolds = _checkout.GetCurrentHolds(id)
                .Select(a => new AssetHoldModel
                {
                    HoldPlaced = _checkout.GetCurrentHoldPlaced(a.Id).ToString("d"),
                    PatronName = _checkout.GetCurrentHoldPatronName(a.Id)
                });

            var model = new AssetDetailModel
            {
                AssetId = id,
                Title = asset.Title,
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(id),
                CurrentLocation = asset.Location.Name,
                DeweyCallNumber = _assets.GetDeweyIndex(id),
                ISBN = _assets.GetIsbn(id),
                LatestCheckout = _checkout.GetLatestCheckout(id),
                PatronName = _checkout.GetCurrentCheckoutPatron(id),
                CurrentHolds = currentHolds,
                CheckoutHistories = _checkout.GetCheckoutHistories(id)
            };         


            return View(model);
        }

        public async Task<IActionResult> Checkout(int id)
        {
            var asset = await _assets.GetByIdAsync(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = _checkout.IsCheckedOut(id)
            };

            return View(model);
        }

        public IActionResult CheckIn(int id)
        {
            _checkout.CheckInItem(id);
            return RedirectToAction("Detail", new { id });
        }

        public async Task<IActionResult> Hold(int id)
        {
            var asset = await _assets.GetByIdAsync(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = _checkout.IsCheckedOut(id),
                HoldCount = _checkout.GetCurrentHolds(id).Count()
            };

            return View(model);
        }

        public IActionResult MarkLost(int assetid)
        {
            _checkout.MarkLost(assetid);

            return RedirectToAction("Detail", new { id = assetid });
        }

        public IActionResult MarkFound(int assetid)
        {
            _checkout.MarkFound(assetid);

            return RedirectToAction("Detail", new { id = assetid });
        }

        [HttpPost]
        public IActionResult PlaceCheckout(int assetId, int libraryCardId)
        {
            _checkout.CheckOutItem(assetId, libraryCardId);

            return RedirectToAction("Detail", new { id = assetId });
        }

        [HttpPost]
        public IActionResult PlaceHold(int assetId, int libraryCardId)
        {
            _checkout.PlaceHold(assetId, libraryCardId);

            return RedirectToAction("Detail", new { id = assetId });
        }
    }
}