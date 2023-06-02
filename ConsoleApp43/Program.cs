using System;
using System.Collections.Generic;

namespace Assignment2
{    
    public enum HouseTypes
    {
        House = 1,
        Business,
        Farmers
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
            Console.ReadKey();
        }

        public void Run()
        {
            Console.WriteLine("Welocome");
            List<PropertyDetails> myList = new List<PropertyDetails>();
            string answer = string.Empty;
            do
            {
                string ageOfHouse = string.Empty;
                decimal houseAge;
                do
                {
                    Console.Write("\nEnter house age: ");
                    ageOfHouse = Console.ReadLine();
                    houseAge = decimal.Parse(ageOfHouse);
                } while (ageOfHouse.Length == 0);

                string sizeOfHouse = string.Empty;
                decimal houseSize;
                do
                {
                    Console.Write("Enter house size: ");
                    sizeOfHouse = Console.ReadLine();
                    houseSize = decimal.Parse(sizeOfHouse);
                } while (sizeOfHouse.Length == 0);

                string sizeOfPaddock = string.Empty;
                decimal paddockSize;
                do
                {
                    Console.Write("Enter paddock size: ");
                    sizeOfPaddock = Console.ReadLine();
                    paddockSize = decimal.Parse(sizeOfPaddock);
                } while (sizeOfPaddock.Length == 0);

                string ccNumber = string.Empty;
                var v = new PropertyDetails();
                do
                {
                    Console.Write("Enter credit card number: ");
                    ccNumber = Console.ReadLine();
                } while (!v.CheckCreditCard(ccNumber));

                int ownerType = 0; //ownerType
                string stringOwner = string.Empty;

                do
                {
                    Console.Write("Enter property owner[1-House, 2-Business, 3-Farmer]: ");
                    stringOwner = Console.ReadLine();
                } 
                while (!(int.TryParse(stringOwner, out ownerType) && ownerType >= (int)HouseTypes.House && ownerType <= (int)HouseTypes.Farmers));

                PropertyDetails theProperty = null;
                switch (ownerType)
                {
                    case (int)HouseTypes.House:
                        theProperty = new House() { HouseAge = houseAge, HouseSize = houseSize, PaddockSize = paddockSize, CCNumber = ccNumber };
                        string needHvac = string.Empty;
                        do
                        {
                            Console.Write("do you need HVAC system?[Y/N]");
                            needHvac = Console.ReadLine();
                        } while (needHvac.Length != 1 || (needHvac != "Y" && needHvac != "N"));
                        ((House)theProperty).HVAC = (needHvac == "Y") ? true : false;
                        break;

                    case (int)HouseTypes.Business:
                        theProperty = new Business() { HouseAge = houseAge, HouseSize = houseSize, PaddockSize = paddockSize, CCNumber = ccNumber };
                        string needSofaset = string.Empty;
                        do
                        {
                            Console.Write("do you need sofaset?[Y/N]");
                            needSofaset = Console.ReadLine();
                        } while (needSofaset.Length != 1 || (needSofaset != "Y" && needSofaset != "N"));
                        ((Business)theProperty).SofaSet = (needSofaset == "Y") ? true : false;
                        break;

                    case (int)HouseTypes.Farmers:
                        theProperty = new Farmers() { HouseAge = houseAge, HouseSize = houseSize, PaddockSize = paddockSize, CCNumber = ccNumber };
                        string needGrainCoolers = string.Empty;
                        do
                        {
                            Console.Write("do you need grain coolers?[Y/N]");
                            needGrainCoolers = Console.ReadLine();
                        } while (needGrainCoolers.Length != 1 || (needGrainCoolers != "Y" && needGrainCoolers != "N"));
                        ((Farmers)theProperty).GrainCoolers = (needGrainCoolers == "Y") ? true : false;
                        break;
                }

                myList.Add(theProperty);

                Console.Write("Do you want to enter more?[Y/N]: ");
                answer = Console.ReadLine();
            } while (answer.Length == 0 || answer.Length > 1 || answer.ToUpper() == "Y" );

            foreach(PropertyDetails v in myList)
            {
                Console.WriteLine(v);
                v.CreateDesign();
                v.EstimateWork();
                v.ArrageWorkers();
                v.AdditionalWork();
            }
        }
    }
}
