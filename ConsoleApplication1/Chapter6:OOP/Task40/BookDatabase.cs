using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task40
{
    public class BookDatabase
    {
        private List<Book> _bookBase;

        public BookDatabase()
        {
            _bookBase = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _bookBase.Add(book);
        }

        public BookDatabase BookSearch(string request)
        {
            BookDatabase searchedBook = new BookDatabase();
            foreach(var book in _bookBase)
            {

                if (book.GetAuthor == request || book.GetBookName == request)
                {
                    searchedBook.AddBook(book);
                }
            }

            return searchedBook;
        }
        
        public BookDatabase BookSearch(int request)
        {
            int num;
            BookDatabase searchedBook = new BookDatabase();
            foreach(var book in _bookBase)
            {

                if (book.GetBookYear == request || book.GetBookName == Convert.ToString(request))
                {
                    searchedBook.AddBook(book);
                }
                
            }

            return searchedBook;
        }

        public void ShowBooks()
        {
            foreach (var book in _bookBase)
            {
                Console.WriteLine($"{book.GetAuthor}, {book.GetBookName}, {book.GetBookYear}");
            }
        }

        public void useDataBase()
        {
            bool cycleSwitcher = true;
            int num;
            BookDatabase searchedBooks = new BookDatabase();
            
            while (cycleSwitcher)
            {
                Console.WriteLine("1. Добавить книгу\n2. Найти книги\n3. Показать все книги\n34. Выход");
                string playerAnswer = Convert.ToString(Console.ReadLine());

                switch (playerAnswer)
                {
                    default:
                        Console.WriteLine("Введен неверный символ");
                        break;
                    case "1":
                        Console.WriteLine("Укажите автора");
                        string userAuthorAnswer = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Укажите название");
                        string userBookAnswer = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Укажите год издания");
                        int userYearAnswer = Convert.ToInt32(Console.ReadLine());
                        _bookBase.Add(new Book(userAuthorAnswer, userBookAnswer, userYearAnswer));
                        break;
                    case "2":
                        Console.WriteLine("Укажите автора, название или год");
                        string userAnswer = Convert.ToString(Console.ReadLine());
                        if (int.TryParse(userAnswer, out num))
                        {
                            searchedBooks = BookSearch(num);
                        }
                        else
                        {
                            searchedBooks = BookSearch(userAnswer);
                        }
                        searchedBooks.ShowBooks();
                        break;
                    case "3":
                        foreach (var book in _bookBase)
                        {
                            Console.WriteLine($"{book.GetAuthor}, {book.GetBookName}, {book.GetBookYear}");
                        }
                        break;
                    case "4":
                        cycleSwitcher = false; 
                        break;
                }
                
                
            }
        }
    }
}