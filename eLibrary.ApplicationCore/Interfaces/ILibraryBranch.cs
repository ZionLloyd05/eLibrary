using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Interfaces
{
    public interface ILibraryBranch : IAsyncRepository<LibraryBranch>
    {
        IEnumerable<Patron> GetPatrons(int branchId);
    }
}
