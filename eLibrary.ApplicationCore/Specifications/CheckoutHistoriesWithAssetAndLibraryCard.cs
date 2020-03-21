using Books.ApplicationCore.Specifications;
using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Specifications
{
    public sealed class CheckoutHistoriesWithAssetAndLibraryCard : BaseSpecification<CheckoutHistory>
    {
        public CheckoutHistoriesWithAssetAndLibraryCard(int id)
           : base(history => history.LibraryAsset.Id == id)
        {
            AddInclude(history => history.LibraryAsset);
            AddInclude(history => history.LibraryCard);
        }
    }
}
