using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.Infrastructure.Data;
using eLibrary.Infrastructure.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Infrastructure.Repositories
{
    public class LibraryAssetRepository : LibraryRepository<LibraryAsset>, IAsyncLibraryAssetRepository
    {
        private readonly eLibraryContext _ctx;

        public LibraryAssetRepository(eLibraryContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _ctx.LibraryAssets.OfType<Book>()
                .Where(asset => asset.Id == id).Any();

            var isVideo = _ctx.LibraryAssets.OfType<Video>()
                .Where(asset => asset.Id == id).Any();

            return isBook ?
                _ctx.Books.FirstOrDefault(book => book.Id == id).Author :
                _ctx.Videos.FirstOrDefault(video => video.Id == id).Director
                ?? "Unknown";
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            var asset = _ctx.LibraryAssets.FirstOrDefault(a => a.Id == id);

            return asset.Location;
        }

        public string GetDeweyIndex(int id)
        {
            if (_ctx.Books.Any(book => book.Id == id))
                {
                    return _ctx.Books
                        .FirstOrDefault(book => book.Id == id).DeweyIndex;
                }
            else
                    return "";
        }

        public string GetIsbn(int id)
        {
            if (_ctx.Books.Any(book => book.Id == id))
            {
                return _ctx.Books
                    .FirstOrDefault(book => book.Id == id).ISBN;
            }
            else
                return "";
        }

        public string GetTitle(int id)
        {
            return _ctx.LibraryAssets
                .FirstOrDefault(a => a.Id == id).Title;
        }

        public string GetType(int id)
        {
            var book = _ctx.LibraryAssets.OfType<Book>()
                .Where(b => b.Id == id);

            return book.Any() ? "Book" : "Video";
        }
    }
}
