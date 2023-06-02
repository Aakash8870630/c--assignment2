using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Business : PropertyDetails
    {
        private bool customerLobbies;

        public bool CustomerLobbies { get => customerLobbies; set => customerLobbies = value; }
        public override void AdditionalWork()
        {
            Console.WriteLine("Customer lobbies created");
        }

        public override string ToString()
        {
            return string.Format("Business {0} and customer lobbies {1} hp", base.ToString(), customerLobbies ? "this" : "that");
        }
    }
}
