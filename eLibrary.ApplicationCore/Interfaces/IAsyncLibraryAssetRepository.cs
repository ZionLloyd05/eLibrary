using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ApplicationCore.Interfaces
{
    public interface IAsyncLibraryAssetRepository : IAsyncRepository<LibraryAsset>
    {
        string GetAuthorOrDirector(int id);
        string GetDeweyIndex(int id);
        string GetType(int id);
        string GetTitle(int id);
        string GetIsbn(int id);

        LibraryBranch GetCurrentLocation(int id);
    }
}
