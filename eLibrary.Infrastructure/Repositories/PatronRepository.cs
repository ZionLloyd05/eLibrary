using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eLibrary.Infrastructure.Repositories
{
    public class PatronRepository : LibraryRepository<Patron>, IPatron
    {
        private readonly eLibraryContext _ctx;

        public PatronRepository(eLibraryContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            var cardId = GetPatron(patronId).LibraryCard.Id;

            return _ctx.CheckoutHistories
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId)
                .OrderByDescending(co => co.CheckedOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int patronId)
        {
            var cardId = GetPatron(patronId).LibraryCard.Id;

            return _ctx.Checkouts
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId).ToList();
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = GetPatron(patronId).LibraryCard.Id;

            return _ctx.Holds
                .Include(h => h.LibraryCard)
                .Include(h => h.LibraryAsset)
                .Where(h => h.LibraryCard.Id == cardId)
                .OrderByDescending(h => h.HoldPlaced);
        }

        public Patron GetPatron(int patronId)
        {
            return _ctx.Patrons
                .Include(patron => patron.LibraryCard)
                .FirstOrDefault(patron => patron.Id == patronId);
        }
    }
}
