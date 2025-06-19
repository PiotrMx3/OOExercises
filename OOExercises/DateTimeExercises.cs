using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class DateTimeExercises
    {

        public static void ShowSubmenu()
        {
            Console.WriteLine("H10-Clock");
            Console.WriteLine("H10-Birthday");
            Console.WriteLine("H10-DayOfTheWeek");

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

    }
}
