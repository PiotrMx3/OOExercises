using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{

    internal class Inheritance
    {
    internal class RegisteredLetter
    {
        public double Distance = 0.00;


        public virtual byte Duration
        {
            get
            {
                byte days = (byte)Math.Ceiling(this.Distance / 100.00);
                return days;
            }
        }

          
        public virtual double Price
        {
            get
            {
                double totalDistance = Math.Ceiling(this.Distance / 100.0);
                return ((totalDistance - 1) * 10.00) + 15.00;

            }
        }

    }

    internal class InternationalRegisteredLetter : RegisteredLetter
    {
        public override byte Duration
        {
            get
            {
                byte days = (byte)Math.Ceiling(this.Distance / 50.00);
                return days;
            }
        }


        public override double Price
        {
            get
            {
                double totalDistance = Math.Ceiling(this.Distance / 100.0);
                return ((totalDistance - 1) * 20.00) + 20.00;

            }
        }

    }
    internal class HighPriorityRegisteredLetter : RegisteredLetter
    {
        public override byte Duration
        {
            get
            {
                byte days = (byte)Math.Ceiling(this.Distance / 200.00);
                return days;
            }
        }


        public override double Price
        {
            get
            {
                double totalDistance = Math.Ceiling(this.Distance / 100.0);
                return ((totalDistance - 1) * 30.00) + 30.00;

            } 
        }
    }
        public static void DemoPostOffice()
        {
            List<RegisteredLetter> userLetters = [];
            bool isRunning = true;


            while (isRunning)
            {
                Console.WriteLine("Wat voor brief wil je toevoegen?");
                Console.WriteLine("1. standaard ");
                Console.WriteLine("2. internationaal ");
                Console.WriteLine("3. hoge prioritei ");
                Console.WriteLine("4. geen enkele, we zijn klaar met invoeren ");

                string letterChoice = Console.ReadLine();

                if (letterChoice == "4") break;



                if (letterChoice == "1")
                {
                    Console.WriteLine("Hoe ver moet deze brief gaan? ");

                    double userInput = Convert.ToDouble(Console.ReadLine());
                    RegisteredLetter newStandaardLetter = new RegisteredLetter() { Distance = userInput };
                    userLetters.Add(newStandaardLetter);
                }
                else if (letterChoice == "2")
                {
                    Console.WriteLine("Hoe ver moet deze brief gaan? ");

                    double userInput = Convert.ToDouble(Console.ReadLine());
                    InternationalRegisteredLetter newInternationalLetter = new InternationalRegisteredLetter() { Distance = userInput };
                    userLetters.Add(newInternationalLetter);
                }
                else if (letterChoice == "3")
                {
                    Console.WriteLine("Hoe ver moet deze brief gaan? ");

                    double userInput = Convert.ToDouble(Console.ReadLine());
                    HighPriorityRegisteredLetter newHighPriorityLetter = new HighPriorityRegisteredLetter() { Distance = userInput };
                    userLetters.Add(newHighPriorityLetter);

                }

            }

            for (int i = 0; i < userLetters.Count; i++)
            {
                Console.WriteLine($"Brief {i + 1}: {userLetters[i].Distance}km, reistijd {userLetters[i].Duration} dagen, kostprijs {userLetters[i].Price} euro ");
            }
        } 
    }
}



