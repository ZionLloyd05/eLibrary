using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Interfaces
{
    public interface ILibraryBranch : IAsyncRepository<LibraryBranch>
    {
        IEnumerable<Patron> GetPatrons(int branchId);
        IEnumerable<LibraryAsset> GetAssets(int branchId);
        LibraryBranch Get(int branchId);
        IEnumerable<string> GetBranchHours(int branchId);
        bool IsBranchOpen(int branchId);
        int GetAssetCount(int branchId);
        int GetPatronCount(int branchId);
        decimal GetAssetsValue(int id);
    }
}
