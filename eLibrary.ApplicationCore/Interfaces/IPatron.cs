using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Interfaces
{
    public interface IPatron : IAsyncRepository<Patron>
    {
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId);
        IEnumerable<Hold> GetHolds(int patronId);
        IEnumerable<Checkout> GetCheckouts(int id);
    }
}
