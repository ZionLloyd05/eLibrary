using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.Infrastructure.Data;
using eLibrary.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;

namespace LibraryServices
{
    public class LibraryAssetRepository : LibraryRepository<LibraryAsset>, IAsyncLibraryAssetRepository
    {
        public LibraryAssetRepository(eLibraryContext ctx) : base(ctx)
        {
        }

        public Task<string> GetAuthorOrDirector(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LibraryBranch> GetCurrentLocation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetDeweyIndex(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetIsbn(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetTitle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
