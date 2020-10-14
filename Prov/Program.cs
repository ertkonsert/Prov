using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's a book lmao");
            //skapar ny bok
            Book book1 = new Book();

            book1.PrintInfo();

            Console.WriteLine("Wow, wasn't that fun? Oh I know! Why don't you write in the name for this new book that you totally bought today:");
            Book yourBook = new Book();
            yourBook.ChangeName();

            System.Console.WriteLine("Look!");
            yourBook.PrintInfo();

            //mest för att testa att kunden fungerar, inte för att den gör mycket.
            Customer firstCustomer = new Customer(book1.names);



            


            Console.ReadLine();
        }
    }
}
