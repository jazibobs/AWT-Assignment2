using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UniversityTermTimeService {
    public class UniversityTermTimes : IUniversityTermTimes {
        public List<DateTime> GetHolidayDates(string university, string timeOfYear) {
            List<DateTime> holidayDates = new List<DateTime>();
            DateTime startDate;
            DateTime endDate;

            if (timeOfYear == "xmas") {
                // christmas
                startDate = new DateTime(2018, 12, 15);
                endDate = new DateTime(2019, 01, 06);
            } else if (timeOfYear =="easter") {
                // easter
                startDate = new DateTime(2019, 03, 29);
                endDate = new DateTime(2019, 04, 18);
            } else {
                // summer
                startDate = new DateTime(2019, 06, 25);
                endDate = new DateTime(2019, 09, 11);
            }

            holidayDates.Add(startDate);
            holidayDates.Add(endDate);

            return holidayDates;
        }
    }
}
