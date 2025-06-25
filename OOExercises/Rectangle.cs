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


        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }


        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value > 0)
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
                return this.width * this.height;
            }
        }

        public void MeesageOut()
        {
            if (Height < 1 || Width < 1)
            {
                Console.WriteLine($"Het is verboden een breedte of hogte van 0 of kleiner in te stellen!");
            }
            else
            {

                Console.WriteLine($"Een rechthoek met een breedte van {this.Width}m en een hoogte van {this.Height}m heeft een oppervlakte van {Area:F1}m².");
            }
        }
    }
}
