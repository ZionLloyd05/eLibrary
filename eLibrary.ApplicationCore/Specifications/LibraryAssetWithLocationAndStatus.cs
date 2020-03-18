using Books.ApplicationCore.Specifications;
using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Specifications
{
    public sealed class LibraryAssetWithLocationAndStatus : BaseSpecification<LibraryAsset>
    {
        public LibraryAssetWithLocationAndStatus(int? assetId)
           : base(asset => asset.Id == assetId)
        {
            AddInclude(asset => asset.Location);
            AddInclude(asset => asset.Status);
        }
    }
}
