namespace ConsoleApplication1.Chapter6_OOP.Task41
{
    public class Item
    {
        private string _item;
        
        public Item(string item)
        {
            _item = item;
        }
        
        public override string ToString()
        {
            return _item;
        }
    }
}