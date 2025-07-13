using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Bibliotheek
    {

        public static void RentalBib()
        {
            HashSet<string> usersList = new();
            Queue<string> waitList = new();
            Stack<string> logbook = new();

            usersList.Add("Piotr");
            usersList.Add("Bruno");
            usersList.Add("Nico");
            usersList.Add("Stijn");
            usersList.Add("Stefan");
            usersList.Add("Bruno"); // HashSet laat niet om dubbel waardes toe te voegen.  



            foreach (var item in usersList)
            {
                if(!waitList.Contains(item))
                {
                    waitList.Enqueue(item);
                    logbook.Push(item + " " + "Toegvoegt aan wachtrij");
                }

            }


            ImmutableHashSet<string> immuUser = usersList.ToImmutableHashSet();
            ImmutableQueue<string> immuWaitList = ImmutableQueue.CreateRange(waitList);
            ImmutableStack<string> immuLogBook = ImmutableStack.CreateRange(logbook);

            Console.WriteLine("Gebruikers van Bibliotheek :");
            Console.WriteLine("");
            foreach (var item in immuUser)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            Console.WriteLine("Wachtrij is :");
            Console.WriteLine("");
            foreach (var item in immuWaitList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            foreach (var item in logbook)
            {
                Console.WriteLine(item);
            }
            
            string[] popOutFromStack = logbook.Pop().Split(" "); // zoe kunen we enkel user erui thalen indien nodig

            Console.WriteLine("");

            Console.WriteLine($"Laaste logboek record op de stack is '{logbook.Peek()}'");

            Console.WriteLine("");

            foreach (var item in logbook)
            {
                Console.WriteLine(item);
            }

        }
         

    }
}
