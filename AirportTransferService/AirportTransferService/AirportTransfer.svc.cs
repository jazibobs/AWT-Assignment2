using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirportTransferService {
    public class AirportTransfer : IAirportTransfer {
        public TravelOption GetCheapestTravelOption(string originCity, string destinationCity) {
            
            string[] modesOfTransport = new string[] { "train", "bus", "coach" };
            TravelOption travel = new TravelOption();
            Random rnd = new Random();
            string randomModeOfTransport = modesOfTransport[rnd.Next(0, 3)];

            travel.DestinationAddress = destinationCity + " airport";
            travel.OriginAddress = originCity + " " + randomModeOfTransport + " station";
            travel.TransportType = randomModeOfTransport;
            travel.Price = rnd.Next(50, 101);

            return travel;
        }
    }
}
