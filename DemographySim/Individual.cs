using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographySim
{
    public enum Sex { Male=1, Female=2 }
    internal class Individual
    {
        public int YearOfBirth { get; set; }

        public Sex Sex { get; set;}

        public byte NumberOfChildren { get; set; }

        public bool IsAlive { get; set; }
    }
}
