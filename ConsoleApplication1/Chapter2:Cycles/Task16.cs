using System;

namespace ConsoleApplication1
{
    public class Task16
    {
        public void Start()
        {
            Console.WriteLine("Enter brackets: ");
            string userInput = Console.ReadLine();
            
            int leftBrackets = 0;
            int rightBrackets = 0;
            bool isOpened = true;
            int deep = 0;
            int deepCounter = 0;
            
            foreach (char item in userInput)
            {
                if (item == '(')
                {
                    leftBrackets++;
                    isOpened = true;
                }
                else if (item == ')')
                {
                    rightBrackets++;
                    isOpened = false;
                }
                
                if (isOpened == false)
                {
                    deepCounter += 1;
                }

                if (deepCounter > deep && rightBrackets == leftBrackets)
                {
                    deep = deepCounter;
                    deepCounter = 0;
                }
                else if (deepCounter > deep && rightBrackets != leftBrackets)
                {
                    deep = deepCounter;
                    deepCounter = 1;
                }
            }

            if (leftBrackets == rightBrackets)
            {
                Console.WriteLine($"Brackets are balanced, deep counter is {deep}");
            }
            else
            {
                Console.WriteLine("Brackets are not balanced");
            }
        }
    }
}