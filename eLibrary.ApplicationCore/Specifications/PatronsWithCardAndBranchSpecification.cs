using Books.ApplicationCore.Specifications;
using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Specifications
{
    public sealed class PatronsWithCardAndBranchSpecification : BaseSpecification<Patron>
    {
        public PatronsWithCardAndBranchSpecification()
            : base(null)
        {
            AddInclude(patron => patron.LibraryCard);
            AddInclude(patron => patron.HomeLibraryBranch);
        }
    }
}
