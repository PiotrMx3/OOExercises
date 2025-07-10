using System.IO;
namespace OOExercises
{
    internal class Program
    {



        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!");
                Console.WriteLine("Topic van de uit te voeren oefening?");
                Console.WriteLine("1. DateTime");
                Console.WriteLine("2. Properties en access modifiers");
                Console.WriteLine("3. Immutable Types");

                Console.Write("Maak een keuze: ");

                string choice = Console.ReadLine();


                switch (choice.ToLower())
                {
                    case "1":
                        DateTimeExercises.ShowSubmenu();
                        break;
                    case "2":
                        CombinationOf2Numbers.ClassesAndObjects();
                        break;
                    case "3":
                        Persoon.DemoPersoonClass();
                        break;
                    default:
                        Console.WriteLine("Ongeldig keuze ! ");
                        break;
                }

            }

            
        }
    }
}
