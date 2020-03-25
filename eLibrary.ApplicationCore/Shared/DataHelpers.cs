using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Shared
{
    public class DataHelpers
    {
        public static IEnumerable<string> HumanizeBizHours(IEnumerable<BranchHours> branchHours)
        {
            var hours = new List<string>();

            foreach(var time in branchHours)
            {
                var day = HumanizeDay(time.DayOfWeek);
                var openTime = HimanizeTime(time.OpenTime);
                var closeTime = HimanizeTime(time.CloseTime);

                var timeEntry = $"{day} {openTime} to {closeTime}";
                hours.Add(timeEntry);
            }

            return hours;
        }

        private static object HimanizeTime(int openTime)
        {
            return TimeSpan.FromHours(openTime).ToString("hh':'mm");
        }

        private static object HumanizeDay(int dayOfWeek)
        {
            return Enum.GetName(typeof(DayOfWeek), dayOfWeek);
        }
    }
}
