using AutoMapper;
using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.UI.Models.Catalog;

namespace eLibrary.UI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        private readonly IAsyncLibraryAssetRepository _assets;

        public AutoMapperProfiles(IAsyncLibraryAssetRepository assets)
        {
            _assets = assets;

        }
    }
}
