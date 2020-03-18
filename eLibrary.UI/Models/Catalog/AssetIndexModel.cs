using eLibrary.UI.Models.Catalog;
using System.Collections.Generic;

namespace eLibrary.UI.Models.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetsIndexListingModel> Assets { get; set; }
    }
}
