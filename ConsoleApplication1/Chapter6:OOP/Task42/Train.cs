using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task42
{
    public class Train
    {
        private List<string> _trainComposition;
        
        public Train()
        {
            _trainComposition = new List<string>();
        }

        public void MakeComposition(Travellers passengers)
        {
            int passengersLeft = passengers.TravellersNum();
            while (passengersLeft > 0)
            {
                if (passengersLeft % 100 != 0 && passengersLeft > 99)
                {
                    _trainComposition.Add("Огромный вагон(100)");
                    passengersLeft -= 100;
                    continue;
                }
                if (passengersLeft % 50 != 0 && passengersLeft > 49)
                {
                    passengersLeft -= 50;
                    _trainComposition.Add("Большой вагон(50)");
                    continue;
                }
                if (passengersLeft % 25 != 0 && passengersLeft > 24)
                {
                    passengersLeft -= 25;
                    _trainComposition.Add("Средний вагон(25)");
                    continue;
                }
                if (passengersLeft % 10 != 0 && passengersLeft > 9)
                {
                    passengersLeft -= 10;
                    _trainComposition.Add("Маленький вагон(10)");
                    continue;
                }
                if (passengersLeft <= 10)
                {
                    _trainComposition.Add("Маленький вагон(10 и меньше)");
                    passengersLeft = 0;
                }
            }
        }
        
        public void ShowTrain()
        {
            Console.Write("Численность каждого вагона: ");
            foreach (var railcar in _trainComposition)
            {
                Console.Write(railcar + " ");
                
            }
            
            Console.WriteLine();
        }
    }
}