using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{

    // h17-autoconstructeur 
    interface IAandrijving
    {
        void EnergieToevoegen();
        void Vertragen(int kmPerUurPerSeconde, int doelsnelheid);
        void Versnellen(int kmPerUurPerSeconde, int doelsnelheid);
    }

    interface IVerwarmen
    {
        void Verwarmen(int doelTemperatuur);
    }

    // h17-grootkeuken
    interface IAfkoelen
    {
        void Afkoelen(int doelTemperatuur);
    }
    interface IStoomVerwarmen
    {
        void StoomVerwarmen(int doelTemperatuur);
    }

    interface IWaterDoseren
    {
        void WaterDoseren(int hoeveelheid);
    }


    // h17-Rooster 

    interface IRoosterbaar
    {
        TimeSpan  Tijdsduur { get; }
        string Omschrijving { get; }
    }



    internal class Polymorfisme
    {
        // h17-autoconstructeur 
        public static void DemonstreerAandrijving()
        {
            Auto newAuto = new Auto("Benzine", new AandrijvingBezine());
            newAuto.Aandrijving.Versnellen(100, 2);

            newAuto.SwitchAandrijving(new AandrijvingElekrisch());
            newAuto.Aandrijving.Versnellen(100, 2);

        }

        internal class AandrijvingElekrisch : IAandrijving
        {
            public void EnergieToevoegen()
            {
                Console.WriteLine("EnergieToevoegen - Elektrisch");
            }

            public void Versnellen(int kmPerUurPerSeconde, int doelsnelheid)
            {
                Console.WriteLine("Versnellen - Elektrisch");
            }

            public void Vertragen(int kmPerUurPerSeconde, int doelsnelheid)
            {
                Console.WriteLine("Vertragen - Elektrisch");
            }
        }
        internal class AandrijvingBezine : IAandrijving
        {
            public void EnergieToevoegen()
            {
                Console.WriteLine("EnergieToevoegen - Benzine");
            }

            public void Versnellen(int kmPerUurPerSeconde, int doelsnelheid)
            {
                Console.WriteLine("Versnellen - Benzine");
            }

            public void Vertragen(int kmPerUurPerSeconde, int doelsnelheid)
            {
                Console.WriteLine("Vertragen - Benzine");
            }
        }
        public class AandrijvingCNG : IAandrijving
        {
            public void EnergieToevoegen()
            {
                Console.WriteLine("EnergieToevoegen - CNG");
            }

            public void Versnellen(int kmPerUurPerSeconde, int doelsnelheid)
            {
                Console.WriteLine("Versnellen - CNG");
            }

            public void Vertragen(int kmPerUurPerSeconde, int doelsnelheid)
            {
                Console.WriteLine("Vertragen - CNG");
            }

        }
        internal class Auto
        {
            public string AutoType { get; private set; }
            public IAandrijving Aandrijving { get; private set; }


            public Auto(string autoType, IAandrijving aandrijving)
            {
                this.AutoType = autoType;
                this.Aandrijving = aandrijving;


            }

            public void SwitchAandrijving(IAandrijving @new)
            {
                Aandrijving = @new;
            }


        }

        // h17-grootkeuken
        internal abstract class Ketel
        {
            public int Inhoud { get; private set; }
            public int Temperatuur { get; protected set; }

            public Ketel(int inhoud)
            {
                Inhoud = inhoud;
                Temperatuur = 0;
            }


        }

        internal class StoomKetel : Ketel, IStoomVerwarmen, IAfkoelen, IWaterDoseren 
        {
            public StoomKetel(int inhoud) : base(inhoud)
            {
            }

            public void Afkoelen(int doelTemperatuur)
            {
                Console.WriteLine($"Stoomketel ({Inhoud}l) -- Afkoelen van {Temperatuur}°C naar {doelTemperatuur}°C");
                Temperatuur = doelTemperatuur;
            }

            public void StoomVerwarmen(int doelTemperatuur)
            {
                Console.WriteLine($"Stoomketel ({Inhoud}l) -- StoomVerwarmen van {Temperatuur}°C naar {doelTemperatuur}°C");
                Temperatuur = doelTemperatuur;
            }

            public void WaterDoseren(int hoeveelheid)
            {
                Console.WriteLine($"Stoomketel ({Inhoud}l) -- Water doseren: {hoeveelheid} ml");
            }
        }

        internal class KetelZonderDoseren : Ketel, IVerwarmen
        {
            public KetelZonderDoseren(int inhoud) : base(inhoud)
            {
            }

            public void Verwarmen(int doelTemperatuur)
            {
                Console.WriteLine($"Ketel zonder doseren ({Inhoud}l) -- Verwarmen van {Temperatuur}°C naar {doelTemperatuur}°C");
                Temperatuur = doelTemperatuur;
            }
        }
        internal class KetelMetDoseren : Ketel, IVerwarmen, IWaterDoseren
        {
            public KetelMetDoseren(int inhoud) : base(inhoud)
            {
            }

            public void Verwarmen(int doelTemperatuur)
            {
                Console.WriteLine($"Ketel met doseren ({Inhoud}l) -- Verwarmen van {Temperatuur}°C naar {doelTemperatuur}°C");
                Temperatuur = doelTemperatuur;
            }

            public void WaterDoseren(int hoeveelheid)
            {
                Console.WriteLine($"Ketel met doseren ({Inhoud}l) -- Water doseren: {hoeveelheid} ml");
            }
        }

        public static void DemonstreerGrootkeuken()
        {
            StoomKetel ketel1 = new (3000);
            StoomKetel ketel2 = new(300);

            KetelZonderDoseren ketel3 = new(150);
            KetelZonderDoseren ketel4 = new(300);

            KetelMetDoseren ketel5 = new(200);
            KetelMetDoseren ketel6 = new(150);


            ketel1.StoomVerwarmen(100);
            ketel2.Afkoelen(20);

            ketel3.Verwarmen(100);

            ketel5.Verwarmen(200);
            ketel6.WaterDoseren(100);
        }


        // h17-Rooster-stap1

        internal class Afspraak : IRoosterbaar
        {
            public TimeSpan VerplaatsenAfspraak { get; private set; }
            public TimeSpan TerugKomenAfspraak { get; private set; }
            public TimeSpan DuurAfspraak { get; private set; }
            public string TitelAfspraak { get; private set; } = "";

            public TimeSpan Tijdsduur
            {
                get { return VerplaatsenAfspraak + TerugKomenAfspraak + DuurAfspraak ; }
            }

            public string Omschrijving
            {
                get { return TitelAfspraak + " (inclusief verplaatsing)"; }
            }



            public Afspraak(TimeSpan verplaatsenAfspraak, TimeSpan terugKomenAfspraak, TimeSpan duurAfspraak, string titelAfspraak)
            {
                VerplaatsenAfspraak = verplaatsenAfspraak;
                TerugKomenAfspraak = terugKomenAfspraak;
                DuurAfspraak = duurAfspraak;
                TitelAfspraak = titelAfspraak;
            }

        }

        internal class Taak : IRoosterbaar
        {
            public TimeSpan WerktijdTaak { get; private set; }
            public string TitelTaak { get; private set; } = "";

            public TimeSpan Tijdsduur
            {
                get { return WerktijdTaak; }
            }

            public string Omschrijving
            {
                get { return TitelTaak; }
            }

            public Taak(TimeSpan werktijdTaak, string titelTaak)
            {
                WerktijdTaak = werktijdTaak;
                TitelTaak = titelTaak;
            }



        }

        public static void DemonstreerIRoosterbaar()
        {
            IRoosterbaar blok1 = new Afspraak(new TimeSpan(0, 20, 0), new TimeSpan(1, 0, 0), new TimeSpan(0, 20, 0), "tandarts");
            IRoosterbaar blok2 = new Taak(new TimeSpan(2, 0, 0), "dagelijkse oefeningen OOP");
            Console.WriteLine($"Totale kalendertijd: {(blok1.Tijdsduur + blok2.Tijdsduur).Hours}u{(blok1.Tijdsduur + blok2.Tijdsduur).Minutes}m");
        }


        internal class Kalender
        {
            public string KalenderNaam { get; }
            private Dictionary<DateTime, IRoosterbaar> _afspraken = new Dictionary<DateTime, IRoosterbaar>();

            public ImmutableDictionary<DateTime, IRoosterbaar> Afspraken
            {
                get { return this._afspraken.ToImmutableDictionary(); }
            }

            private void AfspraakMaken()
            {


                Console.WriteLine("Omschrijving ?");
                string omschrijving = Console.ReadLine();

                Console.WriteLine("Aantal minuten veplaatsing ?");
                int verplaatsing = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Aantal minuten afspraak zelf ?");
                int aspraakTijd = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Aantal minuten om terug te keren ?");
                int terugKeren = Convert.ToInt32(Console.ReadLine());

                var nieuweAfpsraak = new Afspraak(new TimeSpan(0, verplaatsing, 0), new TimeSpan(0, terugKeren, 0), new TimeSpan(0, aspraakTijd, 0), omschrijving);

                Console.WriteLine("Wanneer moet dit geroosterd worden ? (DD/MM/JJJJ UU:MM (PM/AM))");
                DateTime date = DateTime.Parse(Console.ReadLine());

                date = date - nieuweAfpsraak.VerplaatsenAfspraak;
                this._afspraken.Add(date, nieuweAfpsraak);


            }

            public Kalender(string name)
            {
                KalenderNaam = name;
            }

            public void VoegToe()
            {
                Console.WriteLine("Om wat voor object gaat het ?");
                Console.WriteLine("1. Afspraak");
                Console.WriteLine("2. Taak");

                string userInput;

                while (true)
                {
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            AfspraakMaken();
                            break;
                        case "2":
                            // TODO : Taak metode
                            break;
                        default:
                            Console.WriteLine("Verkeerde keuze !");
                            continue;
                    }


                    Console.WriteLine("Wil jij nog een item toevoegen? (ja/nee)");
                    userInput = Console.ReadLine().Trim();

                    if (userInput.Trim().ToLower() == "nee") break;
                }

            }




        }

        public static void DemoAfspraken()
        {
            var nieuweKalender = new Kalender("Super");
            nieuweKalender.VoegToe();

                Console.WriteLine();

                foreach (var kv in nieuweKalender.Afspraken)
                {
                    Console.WriteLine($"{kv.Key} PM: {kv.Value.Omschrijving}");
                }

        }
    }
}




   


