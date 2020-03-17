using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ApplicationCore.Interfaces
{
    public interface IAsyncLibraryAssetRepository
    {
        Task<string> GetAuthorOrDirector(int id);
        Task<string> GetDeweyIndex(int id);
        Task<string> GetType(int id);
        Task<string> GetTitle(int id);
        Task<string> GetIsbn(int id);

        Task<LibraryBranch> GetCurrentLocation(int id);
    }
}
