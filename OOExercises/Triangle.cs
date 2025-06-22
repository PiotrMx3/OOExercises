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
            this.@base = 1.0;
            this.height = 1.0;

        }

        public double @Base
        {
            get
            {
                return this.@base;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een base van {value} in te stellen!");
                }
                else
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
                if(value <= 0 )
                {
                    Console.WriteLine($"Het is verboden een hogte van {value} in te stellen!");
                }
                else
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


    }
}
