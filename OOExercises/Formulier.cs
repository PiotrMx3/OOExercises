using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
	internal class Formulier
	{
		private readonly List<FormulierVraag> _vragen = new();

		public ImmutableList<FormulierVraag> Vragen
		{
			get { return this._vragen.ToImmutableList(); }
		}

		public Formulier(List<FormulierVraag> vragen)
		{

			try
			{
				if (vragen == null || vragen.Count == 0) throw new ArgumentException("formulier mag niet leeg wijn");

				this._vragen = [..vragen];
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
				throw;
			}

		}

		public void VulIn()
		{
			foreach (var item in Vragen)
			{
				try
				{
					item.ToonVraag();
					item.LeesAntwoord();

				}
				catch (Exception)
				{
					Console.WriteLine("Onverwachte fout wordt naar schij weggeschreven");
					throw;
				}

			}
		}

        public void Toon()
        {
			foreach (var item in Vragen)
			{
				Console.WriteLine(item.Tekst);
				Console.WriteLine(item.Antwoord ?? "Leeg");
			}
        }

    }


	internal abstract class FormulierVraag
	{
		private string _tekst;
		private string? _antwoord = null;


		public string Antwoord
		{
			get { return this._antwoord ?? "Leeg"; }

			protected set
			{
				_antwoord = value ?? throw new ArgumentException("Antwoord mag niet leeg zijn.");
			}

		}


		public string Tekst
		{
			get { return this._tekst; }
			protected set {this._tekst = value ;}
		}


		public FormulierVraag(string tekst)
		{
			Tekst = tekst ?? throw new ArgumentException("Vraag mag niet leeg zijn.");
        }

		public abstract void ToonVraag();
		public abstract void LeesAntwoord();

	}



	internal class FormulierGetalVraag : FormulierVraag
	{
		private int _bovenGrens;
		private int _onderGrens;

		public int BovenGrens
		{
			get { return this._bovenGrens; }
		}

		public int OnderGrens
		{
			get { return _onderGrens; }
		}

		public FormulierGetalVraag(string tekst, int onderGrens, int bovenGrens) : base(tekst)
		{
			if(onderGrens > bovenGrens) throw new ArgumentException("Boven grens moet grote zijn dan ondergrens.");

            _onderGrens = onderGrens;
			_bovenGrens = bovenGrens;

		}


        public override void ToonVraag()
        {
			Console.WriteLine(Tekst);
            Console.WriteLine($"Dit is een getal tussen {OnderGrens} en {BovenGrens}.");
        }

        public override void LeesAntwoord()
        {

			while (true)
			{
				string userInput = Console.ReadLine();


				if (!int.TryParse(userInput,out int result))
				{
                    Console.WriteLine($"Je antwoord moet tussen {OnderGrens} en {BovenGrens} liggen");
					continue;
                }

				if(result >= OnderGrens && result <= BovenGrens)
				{
					Antwoord = Convert.ToString(result);
					break;
				}
				else
				{
					Console.WriteLine($"Je antwoord moet tussen {OnderGrens} en {BovenGrens} liggen");
				}
			
			}
        }


    }
        internal class FormulierVrijeTekstVraag(string tekst) : FormulierVraag(tekst)
        {
            public override void ToonVraag()
            {
				Console.WriteLine(Tekst);
				Console.WriteLine("Sluit af met ENTER ");
            }

            public override void LeesAntwoord()
            {
				string userAnswer = Console.ReadLine() ?? "Geen antwoord";
				
				Antwoord = userAnswer;

            }

        }


}
