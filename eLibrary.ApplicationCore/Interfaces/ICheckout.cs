using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Interfaces
{
    public interface ICheckout : IAsyncRepository<Checkout>
    {
       
        Checkout GetLatestCheckout(int assetId);
        string GetCurrentCheckoutPatron(int assetId);
        DateTime GetCurrentHoldPlaced(int id);

        void PlaceHold(int assetId, int libraryCardId);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);
        string GetCurrentHoldPatronName(int id);

        IEnumerable<Hold> GetCurrentHolds(int id);
        IEnumerable<CheckoutHistory> GetCheckoutHistories(int id);
        bool IsCheckedOut(int id);
    }
}
