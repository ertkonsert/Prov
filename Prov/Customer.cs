using System;
using System.Collections.Generic;


namespace Prov
{
    public class Customer
    {
        //variabler
        private string primaryInterest;
        private List<string> ownedBooks;
        private static Random generator = new Random();



        public Customer(List<string> totalBooks)
        {
            //for loop som tar bort upp ett visst antal böcker från listan för att slumpa fram vilka böcker kuden äger, det kan vara all men det kan också vara ingen.
            for (int i = 0; i < generator.Next(totalBooks.Count); i++)
            {
                totalBooks.RemoveAt(generator.Next(totalBooks.Count));
            }
            ownedBooks = totalBooks;

            //bara för att testa så att det fungerar.
            ownedBooks.ForEach(i => Console.Write(i, ", "));
        }


        
    }
}
