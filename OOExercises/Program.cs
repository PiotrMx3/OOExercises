using System.IO;
using System.Runtime.Serialization;
namespace OOExercises
{
    internal class Program
    {

        static void Main(string[] args)
        {

            DemoVet();


            //while (true)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!");
            //    Console.WriteLine("Topic van de uit te voeren oefening?");
            //    Console.WriteLine("1. DateTime");
            //    Console.WriteLine("2. Properties en access modifiers");
            //    Console.WriteLine("3. Immutable Types");
            //    Console.WriteLine("4. Datastructuren");


            //    Console.Write("Maak een keuze: ");

            //    string choice = Console.ReadLine();


            //    switch (choice.ToLower())
            //    {
            //        case "1":
            //            DateTimeExercises.ShowSubmenu();
            //            break;
            //        case "2":
            //            CombinationOf2Numbers.ClassesAndObjects();
            //            break;
            //        case "3":
            //            Persoon.DemoPersoonClass();
            //            break;
            //        case "4":
            //            Datastructuren.Menu();
            //            break;
            //        default:
            //            Console.WriteLine("Ongeldig keuze ! ");
            //            break;
            //    }

            //}


        }

        public static void DemoVet()
        {
            var patients = new List<Animal>();
            var animal1 = new Dog();
            animal1.IndividualAllergies = new List<string> { "vis" };
            animal1.Chip = "ABC123";
            animal1.Gender = Genders.Female;
            animal1.Name = "Misty";
            patients.Add(animal1);
            var animal2 = new Parrot();
            animal2.Gender = Genders.Male;
            animal2.Name = "Coco";
            patients.Add(animal2);
            foreach (var animal in patients)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Gender);
                Console.WriteLine("allergieën:");
                foreach (var allergie in animal.Allergies)
                {
                    Console.WriteLine(allergie);
                }
                animal.ShowChip();
            }
        }


    }
}
