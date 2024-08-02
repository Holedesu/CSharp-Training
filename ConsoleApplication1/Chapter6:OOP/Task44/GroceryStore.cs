using System;
using ConsoleApplication1.Chapter6_OOP.Task41;

namespace ConsoleApplication1.Chapter6_OOP.Task44
{
    public class GroceryStore
    {
        public static void RunStore()
        {
            Console.WriteLine("How many customer do we have today?");
            
            var numberOfCustomer = Convert.ToInt32(Console.ReadLine());

            if (numberOfCustomer == 0)
            {
                Console.WriteLine("Yay, weekend!");
                return;
            }
            CustomerQueue customerQueue = new CustomerQueue(numberOfCustomer);

            while (customerQueue.GetLength() > 0)
            {
                customerQueue.CheckPayable();
            }

            Console.WriteLine("Yay, weekend!");
        }
    }
}