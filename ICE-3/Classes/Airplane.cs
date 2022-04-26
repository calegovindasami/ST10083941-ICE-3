using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3.Classes
{
    class Airplane : Vehicle
    {
        public Airplane(string engineType, int numberOfSeats, string color, double wingSpan, int numberOfEmergecyExits, string propellerType)
        {
            EngineType = engineType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            WingSpan = wingSpan;
            NumberOfEmergecyExits = numberOfEmergecyExits;
            PropellerType = propellerType;
        }

        public double WingSpan { get; set; }
        public int NumberOfEmergecyExits { get; set; }
        public string PropellerType { get; set; }
    }
}
