namespace ConsoleApplication1.Chapter6_OOP.Task40
{
    public class Book
    {
        private string _author;
        private string _bookName;
        private int _bookYear = -1;

        public Book(string author, string bookName, int bookYear)
        {
            _author = author;
            _bookName = bookName;
            _bookYear = bookYear;
        }
        
        public Book()
        {
            
        }

        public string GetAuthor => _author;
        public string GetBookName => _bookName;
        public int GetBookYear => _bookYear;

        public bool IsEmpty()
        {
            if (_bookYear == -1)
            {
                return true;
            }

            return false;
        }

    }
}