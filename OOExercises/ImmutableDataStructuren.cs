using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class ImmutableDataStructuren
    {


        public static void oefening1()
        {
            List<string> list = new List<string>();

            list.Add("apple");
            list.Add("banaan");
            list.Add("kers");


            ImmutableList<string> listImmu = list.ToImmutableList();

            Console.WriteLine("Eerste Lijst : \n");

            foreach (string item in listImmu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            ImmutableList<string> listTwo = ImmutableList<string>.Empty;

            listTwo = listTwo.Add("Kaas");
            listTwo = listTwo.Add("Brood");
            listTwo = listTwo.Add("Pistache");


            Console.WriteLine("Tweede Lijst : \n");

            foreach (string item in listTwo)
            {
                Console.WriteLine(item);
            }

        }

        public static void oefening2() 
        {
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");

            int index = list.IndexOf("A");

            if(index != -1)
            {
                list[index] = "Z";
            }
            else
            {
                Console.WriteLine("Index niet gevonden !");
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            ImmutableList<string> immuList = list.ToImmutableList();

            // immuList[0] = "A"; Property or indexer 'property' cannot be assigned to -- it is read only

            Console.WriteLine("");

            foreach (var item in immuList)
            {
                Console.WriteLine(item);
            }
        }

        public static void oefening3()
        {

            ImmutableList<string>.Builder builder = ImmutableList.CreateBuilder<string>();

            bool nextItem = false;


            do
            {
                Console.WriteLine("Wat wil jij toevoegen ?");
                builder.Add(Console.ReadLine());

                Console.WriteLine("Wil jij nog iets toevoegen ?");

                nextItem = Console.ReadLine().ToLower() == "ja";

            } while (nextItem);

            ImmutableList<string> immuList = builder.ToImmutableList<string>();

            foreach (var item in immuList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
