using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HolidayBrokerService {
    public class HolidayBroker : IHolidayBroker {

        public List<Holiday> GetHolidayOptions(DateTime startDate, DateTime endDate, int budget) {
            Holiday xmasTrip1 = new Holiday("Birmingham", "Rome", "Rome", "Grand Hotel Rome", new DateTime(2018, 12, 27), new DateTime(2018, 01, 05), 475);
            Holiday xmasTrip2 = new Holiday("London City", "Lisbon", "Lisbon", "Grand Hotel Lisbon", new DateTime(2018, 12, 29), new DateTime(2018, 01, 04), 450);
            Holiday easterTrip1 = new Holiday("Manchester", "Paris", "Paris", "Grand Hotel Paris", new DateTime(2019, 04, 01), new DateTime(2019, 04, 08), 500);
            Holiday easterTrip2 = new Holiday("Leeds", "Madrid", "Madrid", "Grand Hotel Madrid", new DateTime(2019, 04, 01), new DateTime(2019, 04, 09), 425);
            Holiday summerTrip1 = new Holiday("Manchester", "Oslo", "Oslo", "Grand Hotel Oslo", new DateTime(2019, 07, 01), new DateTime(2019, 07, 15), 400);
            Holiday summerTrip2 = new Holiday("Liverpool", "Shanghai", "Suzhou", "Grand Hotel Suzhou", new DateTime(2019, 07, 01), new DateTime(2019, 07, 15), 750);
            List<Holiday> dummyHolidayData = new List<Holiday>();

            dummyHolidayData.Add(xmasTrip1);
            dummyHolidayData.Add(xmasTrip2);
            dummyHolidayData.Add(easterTrip1);
            dummyHolidayData.Add(easterTrip2);
            dummyHolidayData.Add(summerTrip1);
            dummyHolidayData.Add(summerTrip2);

            List<Holiday> holidayOptions = new List<Holiday>();

            foreach (Holiday holiday in dummyHolidayData) {

                int dateStartCompare = DateTime.Compare(startDate, holiday.StartDate);
                int dateEndCompare = DateTime.Compare(endDate, holiday.EndDate);

                if (dateStartCompare <= 0 && dateEndCompare >= 0 && budget >= holiday.Price) {
                    holidayOptions.Add(holiday);
                }
            }

            return holidayOptions;
        }
    }
}
