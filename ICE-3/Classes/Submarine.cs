using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3.Classes
{
    class Submarine : Vehicle
    {
        public Submarine(string engineType, int numberOfSeats, string color, string propellerType, string divingPlaneType, double maximumDepth)
        {
            EngineType = engineType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            PropellerType = propellerType;
            DivingPlaneType = divingPlaneType;
            MaximumDepth = maximumDepth;
        }

        public string PropellerType { get; set; }
        public string DivingPlaneType { get; set; }
        public double MaximumDepth { get; set; }
    }
}
