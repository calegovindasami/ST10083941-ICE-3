using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3.Classes
{
    class Helicopter : Vehicle
    {
        public Helicopter(string engineType, int numberOfSeats, string color, int numberOfBlades, double bladeLength, string rotorType)
        {
            EngineType = engineType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            NumberOfBlades = numberOfBlades;
            BladeLength = bladeLength;
            RotorType = rotorType;
        }

        public int NumberOfBlades { get; set; }
        public double BladeLength { get; set; }
        public string RotorType { get; set; }
    }
}
