using System;

using ConsoleApplication1.Chapter6_OOP.Task40;
// using ConsoleApplication1.Chapter6_OOP.Task37;
// using ConsoleApplication1.Chapter3_Arrays;
// using ConsoleApplication1.Chapter4_Functions;
// using ConsoleApplication1.Chapter5_Collections;
// using ConsoleApplication1.Chapter6_OOP.Task36;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Агата Кристи", "Убийство в восточном экспрессе", 1888);
            Book book2 = new Book("Агата Кристи", "В восточном экспрессе убийство", 1788);
            Book book3 = new Book("Оруэлл", "1984", 1966);
            Book book4 = new Book("Кто-то", "Кровавый меридиан", 1988);
            Book book5 = new Book("Кто-то", "Ложная слепота", 1978);
            Book book6 = new Book("Кто-то", "У меня нет рта, а я должен кричать", 1988);
            Book book7 = new Book("Йцйццу", "выщшвоо", 1688);
            Book book8 = new Book("чсмистьи", "12093к9пшо", 1688);
            Book book9 = new Book("дльортп", "457п3рагрмвшщ", 1688);

            BookDatabase data = new BookDatabase();
            data.AddBook(book);
            data.AddBook(book2);
            data.AddBook(book3);
            data.AddBook(book4);
            data.AddBook(book5);
            data.AddBook(book6);
            data.AddBook(book7);
            data.AddBook(book8);
            data.AddBook(book9);
            
            data.useDataBase();
        }
    }
}