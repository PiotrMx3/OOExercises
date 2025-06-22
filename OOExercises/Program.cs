namespace OOExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!");
            Console.WriteLine("Topic van de uit te voeren oefening?");
            Console.WriteLine("1. DateTime");
            Console.WriteLine("2. Properties en access modifiers");


            while (true)
            {

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
                    default:
                        Console.WriteLine("Ongeldig keuze ! ");
                        break;
                }

            }


        }
    }
}
