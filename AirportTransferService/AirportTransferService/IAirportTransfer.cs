using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirportTransferService {
    [ServiceContract]
    public interface IAirportTransfer {
        [OperationContract]
        TravelOption GetCheapestTravelOption(string originCity, string destinationCity);
    }

    [DataContract]
    public class TravelOption {
        string originAddress;
        string destinationAddress;
        string transportType;
        int price;

        [DataMember]
        public string OriginAddress { get => originAddress; set => originAddress = value; }

        [DataMember]
        public string DestinationAddress { get => destinationAddress; set => destinationAddress = value; }

        [DataMember]
        public string TransportType { get => transportType; set => transportType = value; }

        [DataMember]
        public int Price { get => price; set => price = value; }
    }
}