namespace ConsoleApplication1.Chapter6_OOP.Task44
{
    public class Grocery
    {
        private string _grocery;
        private int _price;

        public Grocery(string name, int price)
        {
            _grocery = name;
            _price = price;
        }

        public string GroceryName
        {
            get
            {
                return _grocery;
            }
        }
        
        public int Price
        {
            get
            {
                return _price;
            }
        }
    
    }
}
