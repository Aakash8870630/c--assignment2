using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Business : PropertyDetails
    {
        private bool needSofaset;

        public bool SofaSet { get => needSofaset; set => needSofaset = value; }
        public override void AdditionalWork()
        {
            Console.WriteLine("Customer lobbies created");
        }

        public override string ToString()
        {
            return string.Format("\nBusiness {0} {1}", base.ToString(), needSofaset ? "with sofa set" : "without sofa set");
        }
    }
}
