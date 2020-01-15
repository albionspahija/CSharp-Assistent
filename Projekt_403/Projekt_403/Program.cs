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
            Console.WriteLine("Drücke die (1) wenn du die Fläche eines Rechteckes berrechnen willst,");
            Console.WriteLine("Drücke die (2) wenn du die Fläche eines Dreiecks berrechnen willst,");
            Console.WriteLine("Drücke die (3) wenn du die Fläche eines Kreises berrechnen willst,");
            Console.WriteLine("Drücke die (4) wenn du nichts machen willst");
            Console.WriteLine("ACHTUNG!! Bitte halte dich genau an die Angaben, sonst musst du Enter drücken und das Programm beenden!");
            try
            {
                 eingabe = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ihre Eingabe war ungültig, auf wiedersehen!!");
                Environment.Exit(2000);
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
            double laengeRechteck = 0.0;
            double breiteRechteck = 0.0;
            
            Console.Clear();
            Console.WriteLine("Du hast die Nummer 1 gewählt!");
            Console.WriteLine("Geben Sie die Länge des Rechteckes in cm an: ");
            try
            {
                laengeRechteck = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ihre Eingabe war ungültig, auf wiedersehen!!");
                Environment.Exit(2000);
            }
            Console.WriteLine("Geben Sie die Breite des Rechteckes in cm an: ");
            breiteRechteck = Convert.ToInt32(Console.ReadLine());
            double flaecheRechteck = laengeRechteck * breiteRechteck;
            Console.WriteLine("Die Fläche ihres Rechteckes beträgt " + flaecheRechteck + " cm2!");
            Console.WriteLine("Drücken Sie Enter um zu beenden");
        }

        static void nummer_2()
        {
            double laengeSeiteC = 0.0;
            double hoeheDreieck = 0.0;

            Console.Clear();
            Console.WriteLine("Du hast die Nummer 2 gewählt!");
            Console.WriteLine("Geben Sie die Länge der Seite c in cm an: ");

            try
            {
                laengeSeiteC = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ihre Eingabe war ungültig, auf wiedersehen!!");
                Environment.Exit(2000);
            }
            
            Console.WriteLine("Geben Sie die höhe des Dreiecks in cm an: ");
            try
            {
                hoeheDreieck = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ihre Eingabe war ungültig, auf wiedersehen!!");
                Environment.Exit(2000);
            }
            double flaecheDreieck = 0.5 * laengeSeiteC * hoeheDreieck;
            Console.WriteLine("Die Fläche ihres Rechteckes beträgt " + flaecheDreieck + " cm2!");
            Console.WriteLine("Drücken Sie Enter um zu beenden");
        }

        static void nummer_3()
        {
            double radius = 0.0;

            Console.Clear();
            Console.WriteLine("Du hast die Nummer 3 gewählt!");
            Console.WriteLine("Geben Sie den Radius des Kreises in cm an: ");
            try
            {
                radius = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ihre Eingabe war ungültig, auf wiedersehen!!");
                Environment.Exit(2000);
            }
            double flaecheKreis = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("Die Fläche ihres Kreises beträgt " + flaecheKreis + " cm2!");
            Console.WriteLine("Drücken Sie Enter um zu beenden");
        }
    }
}
