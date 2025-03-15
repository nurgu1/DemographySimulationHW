using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographySim
{
    internal class ProbabilityOfBirth
    {
        public int Age { get; set; }
        public byte NumberOfChildren { get; set; }

        public double PBirth { get; set; }
    }
}
