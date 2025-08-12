using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class ExceptionHandling
    {

        public static void DemonstreerKeuzeElementAllExceptions()
        {
            Random random = new();
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1000);
            }


            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Geef de index van het getaal dat je wil zien");

                try
                {
                    int indexChoice = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"het getal is {arr[indexChoice]}");

                    Console.WriteLine("Wil jij door gaan ? (ja/nee) ");
                    string userChoice = Console.ReadLine();


                    if (userChoice.ToLower() != "ja") break;

                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"{e.GetType().Name} {e.Message}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{e.GetType().Name} {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.GetType().Name} {e.Message}");
                }

            }


            Console.WriteLine("Programma beeindigd.");
        }



        public static void DemonstreerKeuzeElement()
        {
            Random random = new();
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1000);
            }


            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Geef de index van het getaal dat je wil zien");

                try
                {
                    int indexChoice = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"het getal is {arr[indexChoice]}");

                    Console.WriteLine("Wil jij door gaan ? (ja/nee) ");
                    string userChoice = Console.ReadLine();


                    if (userChoice.ToLower() != "ja") break;

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("UPS deze index hebben we niet maak een andere keuze ");
                }

            }


            Console.WriteLine("Programma beeindigd.");
        }


        private static void DemonstreerFoutafhandelingWeekdagenZonderException()
        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }


        private static void DemonstreerFoutafhandelingWeekdagenMetException()
        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";

            try
            {

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + " Maar geen probleem exception is opgevangen !");
              
            }
        }



        private static void DemonstreerFoutafhandelingOverflowZonderException()
        {
         
            int num1, num2;
            //byte resultaat; // byte = 0 - 255 overflowException
            ushort resultaat;
            num1 = 30;
            num2 = 60;
            resultaat = Convert.ToUInt16(num1 * num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);
        }


        private static void DemonstreerFoutAfhandelingOverflowMetException()
        {
            try
            {
                int num1, num2;
                byte resultaat;
                num1 = 30;
                num2 = 60;
                resultaat = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);

            }
            catch (OverflowException e)
            {

                Console.WriteLine("Het getal is te groot om te converteren naar het gewenste formaat.");
            }
        }


        public static void DemoOverFLowException()
        {
            DemonstreerFoutAfhandelingOverflowMetException();
        }

        public static void DemoOverflow()
        {
            DemonstreerFoutafhandelingOverflowZonderException();
        }

        public static void DemoException()
        {
            DemonstreerFoutafhandelingWeekdagenMetException();
        }

        public static void Demo()
        {
            DemonstreerFoutafhandelingWeekdagenZonderException();
        }




    }
}
