using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Triangle
    {
        private double @base;
        private double height;



        public Triangle()
        {
            this.@Base = 1.0;
            this.Height = 1.0;

        }


        public Triangle(double @base, double height)
        {
            this.@Base = @base;
            this.Height = height;

        }


        public double @Base
        {
            get
            {
                return this.@base;
            }

            set
            {
                if (value > 0)
                {
                    this.@base = value;
                }
                
            }
        }


        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value > 0)
                {
                    this.height = value;
                }


            }
        }



        public double Area
        {
            get
            {
                return this.@base * this.height / 2;
            }
        }


        public void MeesageOut()
        {
            if (Height < 1.0 || @Base < 1.0)
            {
                Console.WriteLine($"Het is verboden een basis of hogte van 0 of kleiner in te stellen!");
            }
            else
            {

                Console.WriteLine($"Een driehoek met een basis van {this.@Base}m en een hoogte van {this.Height}m heeft een oppervlakte van {Area:F1}m².");
            }
        }


    }
}
