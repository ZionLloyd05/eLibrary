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
    public class CheckoutRepository : LibraryRepository<Checkout>, ICheckout
    {
        private readonly eLibraryContext _ctx;

        public CheckoutRepository(eLibraryContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }


        public IEnumerable<CheckoutHistory> GetCheckoutHistories(int id)
        {
            return _ctx.CheckoutHistories
                .Include(hld => hld.LibraryAsset)
                .Include(hld => hld.LibraryCard)
                .Where(hld => hld.LibraryAsset.Id == id);
        }

        public string GetCurrentHoldPatronName(int holdId)
        {
            var hold = _ctx.Holds
                .Include(hld => hld.LibraryAsset)
                .Include(hld => hld.LibraryCard)
                .FirstOrDefault(hld => hld.Id == holdId);

            var cardId = hold.LibraryCard.Id;

            var patron = _ctx.Patrons
                .Include(prtn => prtn.LibraryCard)
                .FirstOrDefault(prtn => prtn.LibraryCard.Id == cardId);

            return patron?.FirstName + " " + patron?.LastName;
        }

        public DateTime GetCurrentHoldPlaced(int holdId)
        {
            return
                _ctx.Holds
                .Include(hld => hld.LibraryAsset)
                .Include(hld => hld.LibraryCard)
                .FirstOrDefault(hld => hld.Id == holdId)
                .HoldPlaced;
        }

        public IEnumerable<Hold> GetCurrentHolds(int id)
        {
            return _ctx.Holds
                .Include(hold => hold.LibraryAsset)
                .Where(hold => hold.LibraryAsset.Id == id);
        }

        public Checkout GetLatestCheckout(int assetId)
        {
            return _ctx.Checkouts
                .Where(checkout => checkout.LibraryAsset.Id == assetId)
                .OrderByDescending(checkout => checkout.Since)
                .FirstOrDefault();
        }

        public void MarkFound(int assetId)
        {
            var now = DateTime.Now;
            UpdateAssetStatus(assetId, "Available");

            RemoveExistingCheckouts(assetId);

            CloseExistingCheckoutHistory(assetId, now);
            
            _ctx.SaveChanges();
        }
              
        public void MarkLost(int assetId)
        {
            UpdateAssetStatus(assetId, "Lost");

            _ctx.SaveChanges();
        }

        public void PlaceHold(int assetId, int libraryCardId)
        {
            var now = DateTime.Now;

            var asset = _ctx.LibraryAssets
                .Include(ast => ast.Status)
                .FirstOrDefault(ast => ast.Id == assetId);

            var card = _ctx.LibraryCards
                .FirstOrDefault(crd => crd.Id == libraryCardId);

            if(asset.Status.Name == "Available")
            {
                UpdateAssetStatus(assetId, "On Hold");
            }

            var hold = new Hold
            {
                HoldPlaced = now,
                LibraryAsset = asset,
                LibraryCard = card
            };

            _ctx.Add(hold);
            _ctx.SaveChanges();
        }

        public void CheckInItem(int assetId)
        {
            var now = DateTime.Now;

            var item = _ctx.LibraryAssets
                .FirstOrDefault(asset => asset.Id == assetId);

            _ctx.Update(item);

            //remove any existing chesckouts on the item
            RemoveExistingCheckouts(assetId);

            //close any existing checkout history
            CloseExistingCheckoutHistory(assetId, now);

            // look for existing holds on the item
            var currentHolds = _ctx.Holds
                .Include(hold => hold.LibraryAsset)
                .Include(hold => hold.LibraryCard)
                .Where(hold => hold.LibraryAsset.Id == assetId);

            // if there are holds, checkout the item to the librarycard with the earliest hold
            if (currentHolds.Any())
            {
                CheckoutToEarliestHold(assetId, currentHolds);
                
                //update the item status to Checked Out
                UpdateAssetStatus(assetId, "Checked Out");
            }
            else
            {
                //otherwise, update the item status to available
                UpdateAssetStatus(assetId, "Available");
            }
            
            _ctx.SaveChanges();
        }

        public void CheckOutItem(int assetId, int libraryCardId)
        {
            if (IsCheckedOut(assetId))
            {
                return;
                // Add logic here to handle feedback to the user;
            }

            var item = _ctx.LibraryAssets
              .FirstOrDefault(asset => asset.Id == assetId);

            _ctx.Update(item);

            UpdateAssetStatus(assetId, "Checked Out");

            var libraryCard = _ctx.LibraryCards
                .Include(card => card.Checkouts)
                .FirstOrDefault(card => card.Id == libraryCardId);

            var now = DateTime.Now;

            var checkout = new Checkout
            {
                LibraryAsset = item,
                LibraryCard = libraryCard,
                Since = now,
                Until = GetDefaultCheckOutTime(now)
            };

            _ctx.Add(checkout);

            var checkoutHistory = new CheckoutHistory
            {
                CheckedOut = now,
                LibraryAsset = item,
                LibraryCard = libraryCard
            };

            _ctx.Add(checkoutHistory);

            _ctx.SaveChanges();
        }

        private DateTime GetDefaultCheckOutTime(DateTime now)
        {
            return now.AddDays(30);
        }

        public bool IsCheckedOut(int assetId)
        {
            var isCheckOut = _ctx.Checkouts
                .Where(co => co.LibraryAsset.Id == assetId)
                .Any();

            return isCheckOut;
        }

        private void UpdateAssetStatus(int assetId, string status)
        {
            var item = _ctx.LibraryAssets
              .FirstOrDefault(asset => asset.Id == assetId);

            _ctx.Update(item);

            item.Status = _ctx.Statuses
                .FirstOrDefault(stat => stat.Name == status);
        }

        private void CloseExistingCheckoutHistory(int assetId, DateTime now)
        {
            //close any existed checkout history
            var history = _ctx.CheckoutHistories
                .FirstOrDefault(hsty => hsty.LibraryAsset.Id == assetId
                    && hsty.CheckedIn == null);

            if (history != null)
            {
                _ctx.Update(history);
                history.CheckedIn = now;
            }

        }

        private void RemoveExistingCheckouts(int assetId)
        {
            //remove any existing checkouts on the item
            var checkout = _ctx.Checkouts
                .FirstOrDefault(ckt => ckt.LibraryAsset.Id == assetId);

            if (checkout != null)
            {
                _ctx.Remove(checkout);
            }
        }


        private void CheckoutToEarliestHold(int assetId, IQueryable<Hold> currentHolds)
        {
            var earliestHold = currentHolds
                .OrderBy(holds => holds.HoldPlaced)
                .FirstOrDefault();

            var card = earliestHold.LibraryCard;

            _ctx.Remove(earliestHold);
            _ctx.SaveChanges();

            CheckOutItem(assetId, card.Id);
        }

        public string GetCurrentCheckoutPatron(int assetId)
        {
            var checkout = GetCheckoutByAssetId(assetId);
            if(checkout == null)
            {
                return "";
            }

            var cardId = checkout.LibraryCard.Id;

            var patron = _ctx.Patrons
                .Include(p => p.LibraryCard)
                .FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron.FirstName+ " " + patron.LastName;
        }

        private Checkout GetCheckoutByAssetId(int assetId)
        {
            var checkout = _ctx.Checkouts
                .Include(co => co.LibraryAsset)
                .Include(co => co.LibraryCard)
                .FirstOrDefault(co => co.LibraryAsset.Id == assetId);

            return checkout;
        }

    }
}
