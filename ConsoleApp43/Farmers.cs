using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Farmers : PropertyDetails
    {
        private bool storageAreas;

        public bool StorageAreas { get => storageAreas; set => storageAreas = value; }

        public override void AdditionalWork()
        {
            Console.WriteLine("Storage areas created");
        }

        public override string ToString()
        {
            return string.Format("Farmers {0} {1}", base.ToString(), storageAreas ? "this": "that");
        }
    }
}
