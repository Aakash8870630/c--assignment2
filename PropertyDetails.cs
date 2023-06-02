using System;

namespace Assignment2
{
    class PropertyDetails
    {
        private decimal houseAge;
        private decimal houseSize;
        private decimal paddockSize;
        private string ccNumber;

        public decimal HouseAge { get => houseAge; set => houseAge = value; }

        public decimal HouseSize { get => houseSize; set => houseSize = value; }

        public decimal PaddockSize { get => paddockSize; set => paddockSize = value; }
        public string CCNumber { get => ccNumber; set => ccNumber = value; }

        private string PrintCreditCard()
        {
            char[] ccNumArr = CCNumber.ToCharArray();
            for(int i = 4;i < 11;i++) 
            { 
                ccNumArr[i] ='X'; 
            }
            return new string(ccNumArr);
        }

        public bool CheckCreditCard(string chceckCCNumber)
        {
            bool result = false;
            if (chceckCCNumber != null && chceckCCNumber != string.Empty)
            {
                char[] CCNumberArray = chceckCCNumber.ToCharArray();
                if (CCNumberArray.Length == 16)
                {
                    for (int i = 0; i < CCNumberArray.Length; i++)
                    {
                        if (char.IsDigit(CCNumberArray[i]))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            return result;
        }


        public void CreateDesign()
        {
            Console.WriteLine("Design created");
        }

        public void EstimateWork()
        {
            Console.WriteLine("Estimation done");
        }

        public void ArrageWorkers()
        {
            Console.WriteLine("Workers arranged");
        }        

        public virtual void AdditionalWork()
        {
            Console.WriteLine("Should not see this");
        }

        public override string ToString()
        {
            return string.Format("with age {0}, size {1}, paddock size {2}, credit card number {3}", houseAge, houseSize, paddockSize, PrintCreditCard());
        }
    }
}
