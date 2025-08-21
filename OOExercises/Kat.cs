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

		public static void DemonstreerLeeftijdKatMetResourceCleanup()
		{
			List<Kat> list = new();
			Random rnd = new();
			int i = 0;

			while (true)
			{
			try
			{
				for (i = 0; i < 20; i++)
				{
					Kat newKat =  new Kat(rnd.Next(30));
					list.Add(newKat);
				}

				Console.WriteLine("Alle katten zijn opgeslagen !");

			}
			catch (Exception e)
			{
				Console.WriteLine($"Ups er ging iets miss: {e.Message} {i} !");
			}
			finally
			{
				list.Clear();
			}
				Console.ReadLine();
			}


		}

    }


    internal class KatMetCustomException
    {
        private int _age;

        public int Age
        {
            get { return this._age; }
            private set
            {
                if (value > 25) throw new KatLeeftijdException((sbyte) value, 0, 25);
                _age = value;
            }
        }

        public KatMetCustomException(int age)
        {
            Age = age;
        }


    }

	internal class KatLeeftijdException : ArgumentException
	{
		public sbyte MeegegevenWaarde { get; }
		public sbyte LaagstMogelijkeWaarde { get; }
		public sbyte HoogstMogelijkeWaarde { get; }

        public override string Message
		{
			get { return $"{this.MeegegevenWaarde} is geen geldige leeftijd. De laagst mogelijke leeftijd is {this.LaagstMogelijkeWaarde} jaar, de hoogst mogelijke leeftijd is {this.HoogstMogelijkeWaarde} jaar."; }
		} 


		public KatLeeftijdException(sbyte waarde, sbyte min,sbyte max)
		{
			MeegegevenWaarde = waarde;
			LaagstMogelijkeWaarde = min;
			HoogstMogelijkeWaarde = max;
		}

    }

}
	