using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter5_Collections
{
    public class Task33
    {
        public void Start()
        {
            List<int> numList = new List<int>();
            bool cycleChecker = true;
            int sum = 0;

            while (cycleChecker)
            {
                Console.WriteLine(
                    "добавитьте число введя любое число\n" +
                    "посчитать введенные числа - sum\n" +
                    "выход - exit");

                string userAnswer = Convert.ToString(Console.ReadLine());
                int num;
                switch (userAnswer)
                {
                    default:
                        if (int.TryParse(userAnswer, out num))
                        {
                            numList.Add(Convert.ToInt32(userAnswer));
                        }
                        break;
                    
                    case "sum":
                        foreach (var number in numList)
                        {
                            sum += number;
                        }
                        Console.WriteLine($"Текущая сумма - {sum}");
                        sum = 0;
                        numList.Clear();
                        break;
                       
                    case "exit":
                        cycleChecker = false;
                        break;
                }

            }
        }
    }
    
    
}