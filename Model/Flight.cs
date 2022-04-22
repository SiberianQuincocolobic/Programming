using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        private int _flightTime;

        public Flight()
        {

        }
        public Flight(string departurePoint, string destinationPoint,int flightTime)
        {
            FlightTime = flightTime;
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
        }
        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("");
                }
                _flightTime = value;
            }
        }
    }
}
