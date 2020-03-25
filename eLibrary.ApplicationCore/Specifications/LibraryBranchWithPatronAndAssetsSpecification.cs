using Books.ApplicationCore.Specifications;
using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace eLibrary.ApplicationCore.Specifications
{
    public sealed class LibraryBranchWithPatronAndAssetsSpecification : BaseSpecification<LibraryBranch>
    {
        public LibraryBranchWithPatronAndAssetsSpecification(int branchId) 
            : base(branch => branch.Id == branchId)
        {
            AddInclude(branch => branch.Patrons);
            AddInclude(branch => branch.LibraryAssets);
        }
    }
}
