using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.Infrastructure.Data;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Checkout> GetCheckouts(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            throw new NotImplementedException();
        }
    }
}
