using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.ApplicationCore.Specifications;
using eLibrary.UI.Models;
using eLibrary.UI.Models.Catalog;
using Microsoft.AspNetCore.Mvc;

namespace eLibrary.UI.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IAsyncLibraryAssetRepository _assets;

        public CatalogController(IAsyncLibraryAssetRepository assets)
        {
            _assets = assets;
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

            var model = new AssetDetailModel();

            model.AssetId = id;
            model.Title = asset.Title;
            model.Year = asset.Year;
            model.Cost = asset.Cost;
            model.Status = asset.Status.Name;
            model.ImageUrl = asset.ImageUrl;
            model.AuthorOrDirector = _assets.GetAuthorOrDirector(id);
            model.CurrentLocation = asset.Location.Name;
            model.DeweyCallNumber = _assets.GetDeweyIndex(id);
            model.ISBN = _assets.GetIsbn(id);

            return View(model);
        }
    }
}