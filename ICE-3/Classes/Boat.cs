using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3.Classes
{
    class Boat : Vehicle
    {
        public Boat(string engineType, int numberOfSeats, string color, int numberOfLifeJackets, string rudderType, string anchorType)
        {
            EngineType = engineType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            NumberOfLifeJackets = numberOfLifeJackets;
            RudderType = rudderType;
            AnchorType = anchorType;
        }

        public int NumberOfLifeJackets { get; set; }
        public string RudderType { get; set; }
        public string AnchorType { get; set; }
    }
}
