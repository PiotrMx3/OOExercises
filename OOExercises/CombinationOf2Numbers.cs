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
            Console.WriteLine("3. DemoFiguresWithConstructor");
            Console.WriteLine("4. DemoPurchase");


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
                case "3":
                    DemoFiguresWithConstructor();
                    break;
                case "4":
                    DemoPurchase();
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

            r1.MeesageOut();

            Rectangle r2 = new Rectangle();
            r2.Width = 2.2;
            r2.Height = 1.5;

            r2.MeesageOut();

            Rectangle r3 = new Rectangle();
            r3.Width = 3;
            r3.Height = 1;

            r3.MeesageOut();




            Triangle t1 = new Triangle();
            t1.Base = 3;
            t1.Height = 1;

            t1.MeesageOut();

            Triangle t2 = new Triangle();
            t2.Base = 2;
            t2.Height = 2;

            t2.MeesageOut();



        }


        public static void DemoFiguresWithConstructor()
        {
            Rectangle r1 = new Rectangle(-1, 0);
            r1.MeesageOut();

            Rectangle r2 = new Rectangle(2.2, 1.5);
            r1.MeesageOut();

            Rectangle r3 = new Rectangle(3, 1.0);
            r3.MeesageOut();

            Triangle t1 = new Triangle(3, 1);
            t1.MeesageOut();

            Triangle t2 = new Triangle(2, 2);
            t2.MeesageOut();


        }

        public static void DemoPurchase()
        {

            FoodPurchase food1 = new FoodPurchase("kaas", 2, 2.45, Convert.ToBoolean(1));
            food1.PrintInfo();

            FoodPurchase food2 = new FoodPurchase("appel", 0, 5555, Convert.ToBoolean(1));
            food2.PrintInfo();


        }

    }
}
