using System;

namespace ConsoleApplication1.Chapter6_OOP.Task42
{
    public class CreateRoute
    {
        private string _startPoint;
        private string _destionationPoint;
    
        public CreateRoute(string startPoint, string destionationPoint)
        {
            _startPoint = startPoint;
            _destionationPoint = destionationPoint;
        }
    
        public void RouteInfo()
        {
            Console.WriteLine("Ваш маршрут: " + _startPoint + " - " + _destionationPoint);
        }
        
        public void RouteInfo(Travellers passengers)
        {
            Console.WriteLine($"Ваш маршрут: {_startPoint} - {_destionationPoint} " +
                              $"\nКоличество пассажиров: {passengers.TravellersNum()}");
        }
        
        public void RouteInfo(Travellers passengers, Train train)
        {
            Console.WriteLine($"Ваш маршрут: {_startPoint} - {_destionationPoint} " +
                              $"\nКоличество пассажиров: {passengers.TravellersNum()}" +
                              "\nТекущий состав: ");
            train.ShowTrain();
        }
    }
}