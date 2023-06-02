using System;

namespace Assignment2
{
    class House : PropertyDetails
    {
        private bool needHvac; //HVAC is Heating, Ventilation, and Air Conditioning system

        public bool HVAC { get => needHvac; set => needHvac = value; }
        public override void AdditionalWork()
        {
            Console.WriteLine("Sun room created");
        }

        public override string ToString()
        {
            return string.Format("\nHouse {0} {1}", base.ToString(), needHvac ? "with HVAC system" : "without HVAC system");
        }
    }
}

