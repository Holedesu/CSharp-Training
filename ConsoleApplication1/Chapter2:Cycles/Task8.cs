using System;

namespace ConsoleApplication1
{
    //Нужно написать программу (используя циклы, обязательно пояснить выбор вашего цикла),
    //чтобы она выводила следующую последовательность 5 12 19 26 33 40 47 54 61 68 75 82 89 96
    //Нужны переменные для обозначения чисел в условии цикла.
    public class Task8
    {
        public void Start()
        {
            int startNum = 5;
            int endNum = 100;
            int sumNum = 7;
            while (startNum < endNum)
            {
                Console.WriteLine(startNum);
                startNum += sumNum;
            }
        }
    }
}