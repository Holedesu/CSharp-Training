using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter5_Collections
{
    public class Task32
    {
        public void Start()
        {
            int totalIncome = 0;
            Queue<int> priceQueue = new Queue<int>();
            priceQueue.Enqueue(100);
            priceQueue.Enqueue(25);
            priceQueue.Enqueue(10);
            priceQueue.Enqueue(47);
            priceQueue.Enqueue(54);
            priceQueue.Enqueue(86);

            while (priceQueue.Count > 0)
            {
                totalIncome += priceQueue.Dequeue();
                Console.WriteLine($"Покупка совершена, текущий доход составляет: {totalIncome}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}