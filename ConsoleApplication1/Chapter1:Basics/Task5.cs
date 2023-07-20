using System;

namespace ConsoleApplication1
{
    public class Task5
    {
        private const int VISITOR_TIME = 10;
        private const int HOUR_IN_MINUTES = 60;
        public void Start()
        {
            int hoursLeft = 0;
            int minutesLeft = 0;
            Console.WriteLine("How many visitors do you see?: ");
            int visitors = Convert.ToInt32(Console.ReadLine());
            
            hoursLeft = (visitors * VISITOR_TIME) / HOUR_IN_MINUTES;
            minutesLeft = (visitors * VISITOR_TIME) % HOUR_IN_MINUTES;
            
            Console.WriteLine($"You have {hoursLeft} hours and {minutesLeft} minutes left");
            
        }
    }
}