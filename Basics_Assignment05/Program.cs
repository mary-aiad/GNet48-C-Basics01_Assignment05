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

            #region Question05
            ///Using the Genre enum above, print the underlying int value of
            ///Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion

            #region Question06
            ///Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre);
            #endregion

            #region Question07
            ///Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            //Genre genre = Genre.Fiction;
            //string genreText = genre.ToString();
            //Console.WriteLine(genreText);
            #endregion

            #region Question08
            ///Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            ///print the result.
            //string genreText = "Science";
            //Genre genre = (Genre) Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genre);
            #endregion
        }
    }
}
