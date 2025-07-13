using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Dictionary
    {
        public static void Oefening1()
        {
            Dictionary<int, string> dictionaryList = new();

            dictionaryList.Add(101, "Jan");
            dictionaryList.Add(202, "Lisa");
            dictionaryList.Add(303, "Bruno");


            Console.WriteLine("Personen in Dictionary :");

            foreach (var item in dictionaryList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }


        public static void Oefening2()
        {
            Dictionary<string, string> woordenboek = new() { { "auto", "voertuig"},{"huis","gebouw" } };

            foreach (var item in woordenboek)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            woordenboek["auto"] = "vierwieler";

        }


        public static void Oefening3()
        {

            Dictionary<string, string> cityBook = new() 
            {   {"Brussel", "Belgie"},
                {"Barcelona", "Spanje"},
                {"Berlijn", "Duitsland"}
            };

            bool running = true;

            while (running)
            {

                Console.WriteLine("Voer een naam van Stad dat jij zoekt");
                string key = Console.ReadLine();

                if(cityBook.ContainsKey(key))
                {
                    Console.WriteLine($"{key} ligt in {cityBook[key]}");
                }
                else
                {
                    Console.WriteLine("niet gevonden !\n" +
                        "Wil jij nogmaals zoeken? (ja/nee)");

                    running = Console.ReadLine().ToLower() != "nee";
                    Console.Clear();
                }

            }

            
        }

        public static void Oefening4()
        {
            Dictionary<int, string[]> clientFavMeals = new();

            clientFavMeals.Add(1, ["pizza", "pasta"]);
            clientFavMeals.Add(2, ["shushi", "ramen"]);


            foreach (var client in clientFavMeals )
            {
                Console.WriteLine($"Klant {client.Key} :");

                foreach (var meal in client.Value)
                {
                    Console.WriteLine($"  - {meal}");
                }

                Console.WriteLine("");
            }

        }

    }
}
