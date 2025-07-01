using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class FoodPurchase
    {
        public bool Refrigerate;
        private string productName;
        private int number;
        private double unitPrice;

        public FoodPurchase(string productName, int amount, double productPrice, bool coold)
        {
            this.productName = productName;
            Number = amount;
            UnitPrice = productPrice;
            this.Refrigerate = coold;

        }

        public void PrintInfo()
        {
            if (Number != 0 && UnitPrice != 0)
            {
                Console.WriteLine($"De totaalprijs van {ProductName} is {CalculateTotalPrice():F1} euro.");
                Console.WriteLine($"De vervaldatum van aankoop is {ExpirationDate:g}.");
            }
        }

        public double CalculateTotalPrice()
        {

            return UnitPrice * Number;
        }


        public DateTime ExpirationDate
        {
            get
            {

                return DateTime.Now.AddMonths(2);

            }
        }
        public double UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                if(value <= 0 || value >= 5000)
                {
                    Console.WriteLine("Ongeldige eenheidprijs !");
                }
                else
                {
                    this.unitPrice = value;
                }
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Ongeldige aantal !");
                }
                else
                {
                    this.number = value;
                }
            }
        }

        public string ProductName
        {
            get 
            { 
                return this.productName.ToUpper();
            }
        }

    }
}
