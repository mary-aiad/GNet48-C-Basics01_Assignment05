using System.Drawing;

namespace Basics_Assignment05
{
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre genre { get; set; }
    }

    enum Genre
    {
        Fiction, 
        NonFiction, 
        Science
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ///Add a private string password = "secret"; field to a Book class. Try to print it from Main
            ///(outside the class). What happens, and why?
            //Book book = new Book();
            //Console.WriteLine(book.password); // Error because it is private
            #endregion

            #region Question02
            ///Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            #endregion

            #region Question03
            ///Add a public string Title; field to Book. Set it and print it from Main.
            //Book book = new Book();
            //book.Title = "Test";
            //Console.WriteLine(book.Title);
            #endregion

            #region Question04
            ///Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            ///assign it Genre.Science, and print it.
            //Book book = new Book();
            //book.genre = Genre.Science;
            //Console.WriteLine(book.genre);
            #endregion
        }
    }
}
