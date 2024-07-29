using System;

namespace ConsoleApplication1.Chapter6_OOP.Task42
{
    public class Travellers
    {
        private int _travellersNum;
        private Random _rand = new Random();
    
        public Travellers()
        {
            _travellersNum = _rand.Next(9, 1000);
        }
        
        public Travellers(int travellersNum)
        {
            _travellersNum = travellersNum;
        }
        
        public int TravellersNum()
        {
            return _travellersNum;
        }
    }
}