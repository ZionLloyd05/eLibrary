using Books.ApplicationCore.Specifications;
using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Specifications
{
    public sealed class LibraryBranchesWithPatronAndAssetsSpecification : BaseSpecification<LibraryBranch>
    {
        public LibraryBranchesWithPatronAndAssetsSpecification ()
            : base(null)
        {
            AddInclude(branch => branch.Patrons);
            AddInclude(branch => branch.LibraryAssets);
        }
    }
}
