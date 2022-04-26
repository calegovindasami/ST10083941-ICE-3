using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3.Classes
{
    class Car : Vehicle
    {
        public Car(string engineType, int numberOfSeats, string color, int numberOfWheels, int numberOfDoors, string hornType)
        {
            EngineType = engineType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            NumberOfWheels = numberOfWheels;
            NumberOfDoors = numberOfDoors;
            HornType = hornType;
        }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string HornType { get; set; }

    }
}
