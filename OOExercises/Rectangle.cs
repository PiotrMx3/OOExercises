using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Rectangle
    {
        private double width;
        private double height;



        public Rectangle()
        {
            this.width = 1.0;
            this.height = 1.0;
        }



        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
                }
                else
                {

                   this.width = value;
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
                if (value <= 0)
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
                return this.width * this.height;
            }
        }

    }
}
