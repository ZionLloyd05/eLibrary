using Books.ApplicationCore.Specifications;
using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Specifications
{
    public sealed class PatronWithCardAndBranchSpecification : BaseSpecification<Patron>
    {
        public PatronWithCardAndBranchSpecification(int id)
            : base(patron => patron.Id == id)
        {
            AddInclude(patron => patron.LibraryCard);
            AddInclude(patron => patron.HomeLibraryBranch);
        }
    }
}
