using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HolidayBrokerService {
    [ServiceContract]
    public interface IHolidayBroker {

        [OperationContract]
        List<Holiday> GetHolidayOptions(DateTime startDate, DateTime endDate, int budget);
    }

    [DataContract]
    public class Holiday {
        string originAirport;
        string destinationAirport;
        string destinationCity;
        string hotelName;
        DateTime startDate;
        DateTime endDate;
        int price;

        public Holiday(string originAirport, string destinationAirport, string destinationCity, string hotelName, DateTime startDate, DateTime endDate, int price) {
            OriginAirport = originAirport;
            DestinationAirport = destinationAirport;
            DestinationCity = destinationCity;
            HotelName = hotelName;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }

        [DataMember]
        public string OriginAirport { get => originAirport; set => originAirport = value; }

        [DataMember]
        public string DestinationAirport { get => destinationAirport; set => destinationAirport = value; }

        [DataMember]
        public string DestinationCity { get => destinationCity; set => destinationCity = value; }

        [DataMember]
        public string HotelName { get => hotelName; set => hotelName = value; }

        [DataMember]
        public DateTime StartDate { get => startDate; set => startDate = value; }

        [DataMember]
        public DateTime EndDate { get => endDate; set => endDate = value; }

        [DataMember]
        public int Price { get => price; set => price = value; }
    }
}
