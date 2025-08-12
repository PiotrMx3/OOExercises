using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOExercises
{
    internal class Meal
    {
		private string _name;
		private double _price;
		public Meal(string name, double price)
		{
			this._name = name;
			this._price = price;
		}

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public virtual void ShowTheMenu()
		{
			Console.WriteLine($"{_name,-35}{_price:F2}");
		}
	}


	internal class ChildrenMeal: Meal
	{
		public ChildrenMeal(string name, double price) : base(name,price)
		{

		}

        public override void ShowTheMenu()
        {
			Random r = new();
			int randomColor = r.Next(1, 16);

			Console.ForegroundColor = (ConsoleColor) randomColor;

            base.ShowTheMenu();

			Console.ResetColor();
        }

    }
}
