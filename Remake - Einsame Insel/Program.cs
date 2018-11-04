using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Version
            float fVersion = 0.1f;

            // Variabeln
            string strEingabe;


            // Hauptmenü Überschrift
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Willkommen auf einer einsamen Insel");
            Console.WriteLine("-----------------------------------");

            

            // Schleifen Beginn für das Spiel
            do
            {
                
                // Hauptmenü Benutzereingabe
                Console.WriteLine("Wähle dein Level:");
                Console.WriteLine("-----------------");
                Console.WriteLine("Leicht (L), Normal(N), Schwer(S)");
                Console.WriteLine("Credits (C), Info Level (I)");
                Console.WriteLine("Spiel Beenden (B)");


                // Eingabe abfragen
                strEingabe = Console.ReadLine().ToLower();

                // Menüpunkte
                Console.Clear();
                switch (strEingabe)
                {
                    case "l":
                        {
                            // Leichtes Level
                        }
                        break;
                    case "n":
                        {
                            // Normales Level
                        }
                        break;
                    case "s":
                        {
                            // Schweres Level
                        }
                        break;
                    case "c":
                        {
                            Credits(fVersion);
                            Benutzereingabe();
                        }
                        break;
                    case "i":
                        {
                            LevelInfo();
                            Benutzereingabe();
                        }
                        break;
                    case "b":
                        {
                            //Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Falsche Eingabe!\nBitte erneut versuchen.");
                        }
                        break;
                }
            } while (strEingabe != "b");

            // Debug/Test ausgabe
            //Console.WriteLine("test");
            //Console.ReadKey();

            // Methoden

        }

        // Methode Credits
        static void Credits(float Version)
        {
            float Ver = Version;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Remake - Einsame Insel Version " + Ver);
            Console.WriteLine("Concept, Development, Design by Denis Kliem\n\n");
            Console.WriteLine("Copyright 2018 by Denis Kliem");
            Console.WriteLine("-----------------------------------------------");
        }

        static void LevelInfo()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Level Informationen");
            Console.WriteLine("-------------------");
            Console.WriteLine("Leicht:\n-Für alle die schnell vorankommen möchten!-\n");
            Console.WriteLine("Normal:\n-Upgradekosten sind höher als bei Leicht, Rest gleich.-\n");
            Console.WriteLine("Schwer:\n-Weniger pro Abbau, Upgrades Teurer, Kosten pro Upgrades erhöhen sich stark!-");
        }

        static void Benutzereingabe()
        {
            Console.Write("\nZum fortführen, bitte eine Taste drücken.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
