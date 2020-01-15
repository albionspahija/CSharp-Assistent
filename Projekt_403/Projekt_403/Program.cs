using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_403
{
    class Program
    {
        //Nicht fertig! Stand 02.2018
        static void Main(string[] args)
        {
            string eingabe = "";
            Console.Write("Gib deinen Namen ein: ");
            string benutzer = Console.ReadLine();
            Console.WriteLine("Hallo " + benutzer + "! Ich bin sozusagen der Siri von HP mit bisschen weniger Intelligenz :) ");
            Console.WriteLine("Ich habe eine interessante Auswahl an Dingen, die wir jetzt machen könnten:");
            Console.WriteLine("Drücke die (1) wenn du etwas berrechnen willst,");
            Console.WriteLine("Drücke die (2) wenn du eine Zufallszahl erraten willst,");
            Console.WriteLine("Drücke die (3) wenn du einen Witz hören willst,");
            Console.WriteLine("Drücke die (4) wenn du nichts machen willst");
            Console.WriteLine("ACHTUNG!! Bitte halte dich genau an die Angaben, sonst musst du Enter drücken und das Programm beenden!");
            try
            {
                 eingabe = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ihre Eingabe war ungültig, drücke Enter um zu beenden");
            }
            switch (eingabe)
            { 
                case ("1"):
                    nummer_1();
                    break;

                case ("2"):
                    nummer_2();
                    break;

                case ("3"):
                    nummer_3();
                    break;

                case ("4"):
                    Console.WriteLine("Vielen Dank für deinen Besuch, auf Wiedersehen!");
                    Console.WriteLine("Drücke Enter um zu beenden");
                    break;
                default:
                    Console.WriteLine("Ihre Eingabe war ungültig, drücke Enter um zu beenden");
                    break;
            }
            Console.Read();
        }
        static void nummer_1()
        {
            Console.Clear();
            Console.WriteLine("Du hast die Nummer 1 gewählt!");
            Console.WriteLine("Du hast folgende Berechnungen zur Auswahl bereit:");
            Console.WriteLine("Um die Fläche eines Rechteckes zu berechnen, drücken Sie die 1,");
            Console.WriteLine("Um den Durchmesser eines Kreises zu berechnen, drücken Sie die 2");
            Console.WriteLine("Um den Umfang eines Quadrates zu berechnen, drücken Sie 3");
            Console.WriteLine("Um zu beenden, drücken Sie die 4");
            string eingabe = Console.ReadLine();
            switch (eingabe)
            {
                case ("1"):
                    Console.WriteLine("Geben Sie die Länge des Rechteckes in cm an: ");
                    int laengeRechteck = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geben Sie die Breite des Rechteckes in cm an: ");
                    int breiteRechteck = Convert.ToInt32(Console.ReadLine());
                    int flaecheRechteck = laengeRechteck * breiteRechteck;
                    Console.WriteLine("Die Fläche ihres Rechteckes beträgt " + flaecheRechteck + " cm!");
                    Console.WriteLine("Drücke Enter um zu beenden");
                    break;
                case ("2"):
                    Console.WriteLine("Geben Sie die Länge der Seite c in cm an: ");
                    int langeSeiteC = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geben Sie die höhe des Dreiecks in cm an: ");
                    int hoeheDreieck = Convert.ToInt32(Console.ReadLine());
                    double flaecheDreieck = 0.5 * langeSeiteC * hoeheDreieck;
                    Console.WriteLine("Die Fläche ihres Rechteckes beträgt " + flaecheDreieck + " cm!");
                    Console.WriteLine("Drücke Enter um zu beenden");
                    break;
                case ("3"):
                    Console.WriteLine("Geben Sie die Länge der Seite c in cm an: ");
                    int langeSeiteC = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geben Sie die höhe des Dreiecks in cm an: ");
                    int hoeheDreieck = Convert.ToInt32(Console.ReadLine());
                    double flaecheDreieck = 0.5 * langeSeiteC * hoeheDreieck;
                    Console.WriteLine("Die Fläche ihres Rechteckes beträgt " + flaecheDreieck + " cm!");
                    Console.WriteLine("Drücke Enter um zu beenden");
                    break;
                case ("4"):
                    Console.WriteLine("Geben Sie die Länge der Seite c in cm an: ");
                    int langeSeiteC = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geben Sie die höhe des Dreiecks in cm an: ");
                    int hoeheDreieck = Convert.ToInt32(Console.ReadLine());
                    double flaecheDreieck = 0.5 * langeSeiteC * hoeheDreieck;
                    Console.WriteLine("Die Fläche ihres Rechteckes beträgt " + flaecheDreieck + " cm!");
                    Console.WriteLine("Drücke Enter um zu beenden");
                    break;
                default:
                    Console.WriteLine("Ihre Eingabe war ungültig, drücke Enter um zu beenden");
                    break;
            }
        }
        static void nummer_2()
        {
            Console.WriteLine("Du hast die Nummer 2 gewählt!");
        }
        static void nummer_3()
        {
            Console.WriteLine("Du hast die Nummer 3 gewählt!");
        }

        static void anfangAuswahl()
        {
            Console.WriteLine("Drücke die (1) wenn du etwas berrechnen willst,");
            Console.WriteLine("Drücke die (2) wenn du eine Zufallszahl erraten willst,");
            Console.WriteLine("Drücke die (3) wenn du Musik hören willst,");
            Console.WriteLine("Drücke die (4) wenn du einen Witz hören willst,");
            Console.WriteLine("Drücke die (5) wenn du nichts machen willst");
            string Eingabe = Console.ReadLine();
            switch (Eingabe)
            {
                case ("1"):
                    nummer_1();
                    break;

                case ("2"):
                    nummer_2();
                    break;

                case ("3"):
                    nummer_3();
                    break;

                case ("4"):
                    Console.WriteLine("Vielen Dank für deinen Besuch, auf Wiedersehen!");
                    Console.WriteLine("Drücke Enter um zu beenden");
                    break;
                default:
                    Console.WriteLine("Ihre Eingabe ist ungültig, bitte nochmals eingeben!");
                    anfangAuswahl();
                    break;
            }

        }
    }
}
