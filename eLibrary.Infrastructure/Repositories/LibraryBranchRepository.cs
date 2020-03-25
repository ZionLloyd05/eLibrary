using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using eLibrary.ApplicationCore.Shared;
using eLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eLibrary.Infrastructure.Repositories
{
    public class LibraryBranchRepository : LibraryRepository<LibraryBranch>, ILibraryBranch
    {
        private readonly eLibraryContext _ctx;

        public LibraryBranchRepository(eLibraryContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public LibraryBranch Get(int branchId)
        {
            return _ctx.LibraryBranches
              .Include(b => b.Patrons)
              .Include(b => b.LibraryAssets)
              .FirstOrDefault(p => p.Id == branchId);
        }

        public int GetAssetCount(int branchId)
        {
            return Get(branchId).LibraryAssets.Count();
        }

        public IEnumerable<LibraryAsset> GetAssets(int branchId)
        {
            return _ctx.LibraryBranches
                .Include(b => b.LibraryAssets)
                .FirstOrDefault(b => b.Id == branchId)
                .LibraryAssets;
        }

        public decimal GetAssetsValue(int branchId)
        {
            var assetsValue = GetAssets(branchId).Select(a => a.Cost);
            return assetsValue.Sum();
        }

        public IEnumerable<string> GetBranchHours(int branchId)
        {
            var hours = _ctx.BranchHours
                .Where(h => h.Branch.Id == branchId);

            return DataHelpers.HumanizeBizHours(hours);
        }

        public int GetPatronCount(int branchId)
        {
            return Get(branchId).Patrons.Count();
        }

        public IEnumerable<Patron> GetPatrons(int branchId)
        {
            return _ctx.LibraryBranches
                .Include(b => b.Patrons)
                .FirstOrDefault(b => b.Id == branchId)
                .Patrons;
        }

        public bool IsBranchOpen(int branchId)
        {
            var currentTimeHour = DateTime.Now.Hour;
            var currentDayOfWeek = (int)DateTime.Now.DayOfWeek + 1;
            var hours = _ctx.BranchHours
                .Where(h => h.Branch.Id == branchId);
            var daysHours = hours.FirstOrDefault(h => h.DayOfWeek == currentDayOfWeek);

            return currentTimeHour < daysHours.CloseTime && currentTimeHour > daysHours.OpenTime;
        }
    }
}
