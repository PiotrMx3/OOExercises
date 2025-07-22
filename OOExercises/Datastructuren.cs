using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Datastructuren
    {
        public static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("Welke oefening wil jij uit te voeren ?\n");
            Console.WriteLine("1. H13-PhoneBookNameNumber");
            Console.WriteLine("2. H13-PhoneBookCityNameNumber");
            Console.WriteLine("3. H13-PhoneBookWithBuilder");
            Console.WriteLine("4. H13-BibApp");

            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    PhoneBookNameNumber();
                    break;
                case "2":
                    PhoneBookCityNameNumber();
                    break;
                case "3":
                    PhoneBookWithBuilder();
                    break;
                case "4":
                    Bibliotheek.RentalBib();
                    break;
                default:
                    Console.WriteLine("Maake een geldige keuze !");
                    break;
            }

        }

        public static void PhoneBookNameNumber()
        {
            Dictionary<string, string> phoneBookNameNumber = new();

            bool addRecord;
            int counter = 0;

            do
            {
                string welcome = counter == 1 
                    ? "Wil je (nog) een naam en nummer inlezen ? (ja/nee)" 
                    : "Wil je een naam en nummer inlezen ? (ja/nee)";

                Console.WriteLine(welcome);

                addRecord = Console.ReadLine().ToLower() == "ja";

                if (!addRecord) break;

                Console.WriteLine("Naam ?");
                string user = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Nummer ?");
                string number = Console.ReadLine();

                Console.WriteLine("");

                if(phoneBookNameNumber.ContainsKey(user))
                {
                    phoneBookNameNumber[user] = number;
                }
                else
                {
                    phoneBookNameNumber.Add(user, number);
                }

                    counter = 1;

            } while (addRecord);

            Console.WriteLine("");

            foreach (var item in phoneBookNameNumber)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("");

        }


        public static void PhoneBookCityNameNumber()
        {
            Dictionary<string, Dictionary<string, string>> phoneBookCityNameNumber = new();

            bool addRecord;
            int counter = 0;

            do
            {
                string welcome = counter == 1
                    ? "Wil je (nog) een gemeente, naam en nummer inlezen ? (ja/nee)"
                    : "Wil je een gemeente, naam en nummer inlezen ? (ja/nee)";

                Console.WriteLine(welcome);

                addRecord = Console.ReadLine().ToLower() == "ja";

                if (!addRecord) break;

                Console.WriteLine("Gemeente? ");

                string cityName = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Naam ?");
                string user = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Nummer ?");
                string number = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine();

                if (!phoneBookCityNameNumber.ContainsKey(cityName))
                {
                    phoneBookCityNameNumber.Add(cityName, new Dictionary<string,string>());
                }


                if(phoneBookCityNameNumber[cityName].ContainsKey(user))
                {
                    phoneBookCityNameNumber[cityName][user] = number;
                }
                else
                {
                    phoneBookCityNameNumber[cityName].Add(user, number);
                }



                counter = 1;
            } while (true);


                foreach (var city in phoneBookCityNameNumber.Keys)
                {
                    Console.WriteLine($"{city} :");

                    foreach (var users in phoneBookCityNameNumber[city])
                    {
                        Console.WriteLine($"{users.Key}: {users.Value}");
                    }
                }

        }

        public static void PhoneBookWithBuilder()
        {

            ImmutableDictionary<string, string>.Builder phoneBookWithBuilder = ImmutableDictionary.CreateBuilder<string, string>();

            bool addRecord;
            int counter = 0;

            do
            {
                string welcome = counter == 1
                    ? "Wil je (nog) een naam en nummer inlezen ? (ja/nee)"
                    : "Wil je een naam en nummer inlezen ? (ja/nee)";

                Console.WriteLine(welcome);

                addRecord = Console.ReadLine().ToLower() == "ja";

                if (!addRecord) break;

                Console.WriteLine("Naam ?");
                string user = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Nummer ?");
                string number = Console.ReadLine();

                Console.WriteLine("");

                if (phoneBookWithBuilder.ContainsKey(user))
                {
                    phoneBookWithBuilder[user] = number;
                }
                else
                {
                    phoneBookWithBuilder.Add(user, number);
                }

                counter = 1;

            } while (addRecord);

            Console.WriteLine("");


            ImmutableDictionary<string, string> phoneBook = phoneBookWithBuilder.ToImmutableDictionary();

            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("");


        }

    }

}
