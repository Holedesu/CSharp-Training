using System;

namespace ConsoleApplication1
{
    public class Task10
    {
        private const float USD_IN_RUB = 70;
        private const double RUB_IN_USD = 1.2;
        
        public void Start()
        {
            float usdNow = 600;
            float rubNow = 65000;
            Console.WriteLine("What option do you want?");
            Console.WriteLine("Type '1' for USD to RUB");
            Console.WriteLine("Type '2' for RUB to USD");
            string option = Console.ReadLine();
            
            Console.WriteLine("How much do you want to convert?: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case "1":
                    usdNow -= amount;
                    rubNow += Convert.ToSingle(amount * RUB_IN_USD);
                    break;
                case "2":
                    rubNow -= amount;
                    usdNow += Convert.ToSingle(amount / USD_IN_RUB);
                    break;
            }
            Console.WriteLine($"Your USD now is {usdNow} and your RUB now is {rubNow}");
        }
    }
}