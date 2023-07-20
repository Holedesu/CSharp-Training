using System;

namespace ConsoleApplication1
{
    public class Task2
    {
        public void Start()
        {
            int rowNum = 0;
            int userAlbum = 0;
            int last = 0;
            bool flag;
            
            Console.WriteLine("How many pictures do you have?: ");
            userAlbum = Convert.ToInt32(Console.ReadLine());
            
            last = userAlbum % 3;
            flag = userAlbum <= 52;
            rowNum = userAlbum / 3;
            last *= Convert.ToInt32(flag);
            rowNum *= Convert.ToInt32(flag);
            Console.WriteLine($"You have {rowNum} rows and {last} pictures last");
        }
    }
}