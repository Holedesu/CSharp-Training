using System;

namespace ConsoleApplication1
{
    public class Task13
    {
        private const string PASSWORD = "123";
        public void Start()
        {
            Console.WriteLine("Enter the password: ");
            for (int i = 0; i < 3; i++)
            {
                string userpassword = Console.ReadLine();
                if (userpassword == PASSWORD)
                {
                    Console.WriteLine("Password is correct");
                    return;
                }
                Console.WriteLine("Password isn't correct try again");
                if (userpassword != PASSWORD && i == 2)
                {
                    Console.WriteLine("Number of tries exceeded, try again later");
                }
            }
        }
    }
}