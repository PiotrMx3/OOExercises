using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class Persoon
    {
        private string name;
        private ImmutableList<string> lievelingsgerechten;



        public Persoon(string name, List<string> builderItems)
        {
            Name = name;

            ImmutableList<string>.Builder builder = ImmutableList.CreateBuilder<string>();

            for (int i = 0; i < builderItems.Count; i++)
            {
                builder.Add(builderItems[i]);
            }

            lievelingsgerechten = builder.ToImmutableList<string>();
        }




       public ImmutableList<string> Lievelingsgerechten
        {
            get
            {
                return this.lievelingsgerechten;
            }
        }

       public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }


        public void ShowOverview()
        {
            Console.WriteLine($"Lievelings gerechten van {Name} :\n");

            foreach (var item in Lievelingsgerechten)
            {
                Console.WriteLine(item);
            }
        }


        public static void DemoPersoonClass()
        {
            List<string> favoritefood = new();
            string personName;

            bool going = false;

            Console.WriteLine("Wat is jij naam ? ");
            personName = Console.ReadLine();

            do
            {
                Console.WriteLine("Wat is jij livelings gerecht ?");
                favoritefood.Add(Console.ReadLine());

                Console.WriteLine("Heb jij nog lievelings gerechtten om toe te voegen ? (ja/nee)");
                going = Console.ReadLine().ToLower() == "ja";

            } while (going);

            Persoon newPpl = new Persoon(personName, favoritefood);

            newPpl.ShowOverview();
        }

    }
}
