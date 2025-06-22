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
            Console.WriteLine("2. DemoFigures");
            Console.WriteLine("3. ");


            Console.Write("Maak een keuze: ");
            string choice = Console.ReadLine();


            switch (choice.ToLower())
            {
                case "1":
                    DemoCombinationOf2Numbers();
                    break;
                case "2":
                    DemoFigures();
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

        public static void DemoFigures()
        {
            Rectangle r1 = new Rectangle();
            r1.Width = -1;
            r1.Height = 0;


            Rectangle r2 = new Rectangle();
            r2.Width = 2.2;
            r2.Height = 1.5;

            Console.WriteLine($"Een rechthoek met een breedte van {r2.Width}m en een hoogte van {r2.Height}m heeft een oppervlakte van {r2.Area:F1}m².");

            Rectangle r3 = new Rectangle();
            r3.Width = 3;
            r3.Height = 1;

            Console.WriteLine($"Een rechthoek met een breedte van {r3.Width}m en een hoogte van {r3.Height}m heeft een oppervlakte van {r3.Area:F1}m².");




            Triangle t1 = new Triangle();
            t1.Base = 3;
            t1.Height = 1;

            Console.WriteLine($"Een driehoek met een basis van {t1.Base}m en een hoogte van {t1.Height}m heeft een oppervlakte van {t1.Area:F1}m².");

            Triangle t2 = new Triangle();
            t2.Base = 2;
            t2.Height = 2;

            Console.WriteLine($"Een driehoek met een basis van {t2.Base}m en een hoogte van {t2.Height}m heeft een oppervlakte van {t2.Area:F1}m².");



        }

    }
}
