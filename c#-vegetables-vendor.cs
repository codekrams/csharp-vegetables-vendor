using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObstGemuese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Obst- und Gemüsesorten möchten Sie anlegen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            ObstGemuese[] Lager = new ObstGemuese[anzahl];

            arrayFuellen(Lager);

            wareKaufen(Lager);

            Console.ReadKey();
        }

        private static void wareKaufen(ObstGemuese[] arr) {

            int eingabe = 0;
            double preis=0.0;
            double endpreis = preis;

            do
            {
                lagerAnzeigen(arr);
                Console.WriteLine("Was möchten Sie kaufen? Bitte wählen Sie die Nummer aus");
                int auswahl = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Wie viel Gramm möchten Sie kaufen?");
                int gramm = Convert.ToInt32(Console.ReadLine());

                preis = (gramm/100) * arr[auswahl].getPreis();

                Console.WriteLine("Preis für {0} Einheiten {1} beträgt: {2} ", gramm, arr[auswahl].getName(), preis);
                endpreis = endpreis + preis;

                Console.WriteLine("Ihr Preis insgesamt: " + endpreis);

                Console.WriteLine("Möchten Sie weitere Waren einkaufen? 1 für Ja, 0 für Nein:");
                eingabe = Convert.ToInt32(Console.ReadLine());
                

            } while (eingabe != 0);
        }

        private static void lagerAnzeigen(ObstGemuese[] arr) {
            Console.WriteLine("Für Obst geben Sie die 1 ein, für Gemüse die 2");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            

            if (auswahl == 1) {
                for (int i = 0; i < arr.Count(); i++)
                {
                    int art = arr[i].getObst();
                    if (art == 1) {
                        Console.WriteLine(i + " " + arr[i].getName());
                       
                    }                       
                }
            }
            if (auswahl == 2)
            {
                for (int i = 0; i < arr.Count(); i++)
                {
                    int art2 = arr[i].getGemuese();
                    if (art2 == 1)
                    {
                        Console.WriteLine(i + " " + arr[i].getName());

                    }
                }
            }


        }

        private static void arrayFuellen(ObstGemuese[] arr)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = getObst();
            }
        }

        private static ObstGemuese getObst()
        {
            ObstGemuese og = null;

            Console.WriteLine("Wie heißt die Sorte?");
            string name = Console.ReadLine();

            Console.WriteLine("Ist es ein Obst? 1 = Ja, 2 = Nein");
            int obst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ist es ein Gemüse? 1 = Ja, 2 = Nein");
            int gemuese = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie teuer ist es pro 100 Gramm?");
            double preis = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie schwer ist eine Einheit?");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wo kommt das Produkt her?");
            string herkunft = Console.ReadLine();

            og = new ObstGemuese(name, preis, obst, gemuese, gewicht, herkunft);

            return og;
        }


    }
}
