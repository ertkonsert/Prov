using System;
using System.Collections.Generic;


namespace Prov
{
    public class Book
    {
        //de variabler jag behöver
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private static Random generator = new Random();

        //varsin array för boknamn och kategorier
        public List<string> names = new List<string>() {"Cool Story, Or Is It?", "Interesting Tale of Something or Other", "You're boring! Here's how to fix it", "The Very Very Very Small Cat", "Pants"};

        public List<string> categories = new List<string>() {"Horror", "Action", "Romance", "Children", "Fairytale", "Folklore", "Science Fiction", "Dystopia"};

        //konstruktorn bestämmer bokens värden förutom priset
        public Book()
        {
            //sätter generatorn till 1, 100 så ett av dem inte kan bli noll och göra boken HELT värdelös. känns lite mer realistiskt så
            actualValue = generator.Next(1, 100);
            rarity = generator.Next(1, 100);
            int i = generator.Next(2);
            if (i == 0)
            {
                cursed = false;
            }
            if (i == 1)
            {
                cursed = true;
            }

            name = names[generator.Next(names.Count)];

            category = categories[generator.Next(categories.Count)];
            
        }

        //metod som skriver ut bokens värden
        public void PrintInfo()
        {
            Console.WriteLine("Here's the facts:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Rarity: " + rarity);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Price: " + price);
        }

        //metod som räknar ut bokens pris
        public int Evaluate()
        {
            price = actualValue*rarity;

            return price;
        }

        //metoderna nedan ger bara ut namnet respektive kategorin på boken
        public string GetName()
        {
            return name;
        }

        public string GetCategory()
        {
            return category;
        }

        //har boken en förbannelse? 80% chans att du gissar rätt på om den har det eller inte
        public bool IsCursed()
        {
            if (generator.Next(100) < 80)
            {
                return cursed;
            }

            else
            {
                return !cursed;
            }
            
        }

        //metod som låter en ändra namnet på en bok, finns kanske bättre sätt att göra detta på men jag har icke tid.
        public void ChangeName()
        {
            name = Console.ReadLine();

        }



    }
}
