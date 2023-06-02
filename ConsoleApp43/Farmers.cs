using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Farmers : PropertyDetails
    {
        private bool needGrainCoolers;

        public bool GrainCoolers { get => needGrainCoolers; set => needGrainCoolers = value; }

        public override void AdditionalWork()
        {
            Console.WriteLine("Grain storage areas created");
        }

        public override string ToString()
        {
            return string.Format("\nFarmers {0} {1}", base.ToString(), needGrainCoolers ? "with grain coolers": "with out grain coolers");
        }
    }
}
