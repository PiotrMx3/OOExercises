using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Order(uint amount, double basisPrice)
    {
        private uint _number = amount;
        private double _unitPrice = basisPrice;

        public uint Number
        {
            get { return this._number; }
        }

        public virtual double TotalPrice
        {
            get
            {
                return this._unitPrice * _number;
            }
        }

        public override string ToString()
        {
            return $"Totaalprijs: {this.TotalPrice:F2} euro";
        }
    }

    internal class InternationalOrder(uint amount, double basisPrice) : Order(amount, basisPrice)
    {

        public override double TotalPrice
        {
            get
            {
                double extraPrice = base.TotalPrice * 1.10;

                return Number >= 100
                    ? extraPrice - 1000.00
                    : extraPrice;
            }
        }

        public override string ToString()
        {
            return $"Totaalprijs: {this.TotalPrice:F2} euro";
        }

    }
}
