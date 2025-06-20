using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class CombinationOf2Numbers
    {
        public static void ClassesAndObjects()
        {
            Console.WriteLine("1. DemoCombinationOf2Numbers");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");


            Console.Write("Maak een keuze: ");
            string choice = Console.ReadLine();


            switch (choice.ToLower())
            {
                case "1":
                    DemoCombinationOf2Numbers();
                    break;
                case "2":
                    //H10Clock();
                    break;
                case "3":
                    //H10DayOfTheWeek();
                    break;
                default:
                    Console.WriteLine("Ongeldig keuze ! ");
                    break;
            }
        }



        public int Number1;
        public int Number2;

        public double Sum()
        {
            return this.Number1 + this.Number2;
        }


        public double Difference()
        {
            if(this.Number1 > this.Number2)
            {
                return this.Number1 - this.Number2;
            }
            else
            {
                return this.Number2 - this.Number1;
            }
        }

        public double Product()
        {
            return this.Number1 * this.Number2;
        }

        public double Quotient()
        {
            if (this.Number1 == 0 || this.Number2 == 0)
            {
                Console.WriteLine("Fout in Quotient");
                return -1;
            }

            return Math.Round((double)this.Number1 / this.Number2, 2) ;
        }


        public static void DemoCombinationOf2Numbers()
        {
            CombinationOf2Numbers pair = new CombinationOf2Numbers();
            pair.Number1 = 12;
            pair.Number2 = 34;
            Console.WriteLine("Paar:" + pair.Number1 + ", " + pair.Number2);
            Console.WriteLine("Som = " + pair.Sum());
            Console.WriteLine("Verschil = " + pair.Difference());
            Console.WriteLine("Product = " + pair.Product());
            Console.WriteLine("Quotient = " + pair.Quotient());
        }

    }
}
