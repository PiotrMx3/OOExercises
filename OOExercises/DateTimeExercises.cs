using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class DateTimeExercises
    {

        public static void ShowSubmenu()
        {
            Console.WriteLine("1. H10-Clock");
            Console.WriteLine("2. H10-Birthday");
            Console.WriteLine("3. H10-DayOfTheWeek");
            Console.WriteLine("4. H10-TicksSince2000");
            Console.WriteLine("5. H10-LeapYearCount");
            Console.WriteLine("5. H10-Codetiming");


            Console.Write("Maak een keuze: ");
            string choice = Console.ReadLine();


            switch (choice.ToLower())
            {
                case "1":
                    H10Clock();
                    break;
                case "2":
                    H10Clock();
                    break;
                case "3":
                    H10DayOfTheWeek();
                    break;
                case "4":
                    H10TicksSince2000();
                    break;
                case "5":
                    H10LeapYearCount();
                    break;
                case "6":
                    H10CodeTiming();
                    break;
                default:
                    Console.WriteLine("Ongeldig keuze ! ");
                    break;
            }
        }



        public static void H10Clock()
        {
            while (true)
            {
                Console.WriteLine($"{DateTime.Now:T}");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public static void H10Birthday()
        {
            Console.WriteLine("Wat is jouz geboortedatum ? (JJJJ/MM/DD)");
            DateTime birthDay =  DateTime.Parse(Console.ReadLine());

            int month = birthDay.Month;
            int day = birthDay.Day;

            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, month, day);

        
            if(nextBirthday.Date < today.Date)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }


            TimeSpan daysNextBirthday = nextBirthday - today; 



            Console.WriteLine($"Aantal dagen tot verjaardag: {daysNextBirthday.TotalDays}");

        }


        public static void H10DayOfTheWeek()
        {
            Console.WriteLine("Wellke dag ?");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wellke maand ?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wellke jaar ?");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime userDate = new DateTime(year, month, day);
            CultureInfo belgiumCI = new CultureInfo("nl-BE");


            Console.WriteLine($"{userDate.ToString("dd MMMM yyyy ", belgiumCI)} is een {userDate.ToString("dddd", belgiumCI)}.");


        }


        public static void H10TicksSince2000()
        {

            DateTime startDate = new DateTime(2000, 1, 1);

            while (true)
            {
                long amount = DateTime.Now.Ticks - startDate.Ticks;

                Console.WriteLine($"Sinds 1 januari 2000 zijn er {amount} ticks voorbijgegaan.");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

            }
        }


        public static void H10LeapYearCount()
        {
            DateTime startYear = new DateTime(1799,1,1);
            DateTime endYear = new DateTime(2021,1,1);


            int counter = 0;
            while (startYear.Year <= endYear.Year)
            {
                bool leapYear = DateTime.IsLeapYear(startYear.Year);

                if (leapYear)
                {
                    counter++;
                } 

                startYear = startYear.AddYears(1);
            }

                Console.WriteLine($"Er zijn {counter} schrikkeljaren tussen 1799 en 2021.");

        }


        public static void H10CodeTiming()
        {
            int[] array = new int[1000000 * 1000];

            DateTime miliOne = DateTime.Now;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            DateTime miliTwo = DateTime.Now;

            TimeSpan diffrence = miliTwo - miliOne;

            Console.WriteLine($"Het duurt {diffrence.TotalMilliseconds} milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden.");
        }

    }
}
