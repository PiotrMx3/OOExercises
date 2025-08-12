using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Kat
    {
		private int _age;

		public int Age
		{
			get { return this._age; }
			private set
			{
				if (value > 25) throw new ArgumentException("Deze kat is te oud!", nameof(Age));
				_age = value;
			}
		}

		public Kat(int age)
		{
			Age = age;
		}

	}
}
	