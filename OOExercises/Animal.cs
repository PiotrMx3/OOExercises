using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
	public enum Genders {Male, Female}


    internal abstract class Animal
    {

		public string Name { get; set; }
		public Genders Gender { get; set; }

		public abstract ImmutableList<string> Allergies { get; }
		public abstract void ShowChip();

    }

	internal class Dog : Animal
	{
		private List<string> _individualAllergies = ["druiven", "noten", "chocolade", "avocado"];
		public string Chip { get; set; }

		public List<string> IndividualAllergies { get; set; }


		public override void ShowChip()
		{
			Console.WriteLine($"Chip nummer van {this.Name} is: {this.Chip}");
		}
        public override ImmutableList<string> Allergies
        {
          get { return this._individualAllergies.ToImmutableList(); }
			
		}


    }

    internal class Parrot : Animal
	{
        private List<string> _individualAllergies = [];

        public List<string> IndividualAllergies { get; set; }


        public override void ShowChip()
        {
            Console.WriteLine($"Papegaaien worden niet gechipt. ");
        }
        public override ImmutableList<string> Allergies
        {
            get { return this._individualAllergies.ToImmutableList(); }

        }
    }
}
