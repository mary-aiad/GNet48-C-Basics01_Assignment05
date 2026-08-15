namespace Basics_Assignment05
{
    class Book
    {
        private string password = "secret";
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
        }
    }
}
