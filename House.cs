using System;

namespace Assignment2
{
    class House : PropertyDetails
    {
        private bool sunRoom;

        public bool SunRoom { get => sunRoom; set => sunRoom = value; }
        public override void AdditionalWork()
        {
            Console.WriteLine("Sun room installed");
        }

        public override string ToString()
        {
            return string.Format("House {0} and \nsun room {1}", base.ToString(), sunRoom ? "installed" : "not installed");
        }
    }
}

