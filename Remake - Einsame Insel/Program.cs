using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class Program
    {

        struct Variablen
        {

        }

        static void Main(string[] args)
        {
            // Version
            float fVersion = 0.5f;

            // Variablen
            string strEingabe;

            // Level Variablen
            int neuesLevel = 1;

            // Ressourcen
            int holz = 0;
            int getHolz = 0;
            int eisen = 0;
            int getEisen = 0;
            int gold = 0;
            int getGold = 0;
            int haus = 0;
            int villa = 0;

            // Gebäude
            int kostenHausHolz = 0;
            int kostenHausGold = 0;
            int addHausEisen = 0;
            int addHausGold = 0;
            int kostenVillaEisen = 0;
            int kostenVillaGold = 0;
            int addVillaHolz = 0;
            int addVillaGold = 0;


            // Hauptmenü Überschrift
            HauptUeberschrift(fVersion);

            // Schleifen Beginn für das Spiel
            do
            {
                // Hauptmenü Benutzereingabe
                HauptBenutzereingaben();

                // Eingabe abfragen
                strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();

                // Menüpunkte
                Console.Clear();
                switch (strEingabe)
                {
                    case "l":
                        {
                            if (neuesLevel == 1)
                            {
                                // Ressourcen nicht nochmal neu setzen
                                neuesLevel = 2;

                                // Ressourcen festlegen
                                holz = 100;
                                getHolz = 50;
                                eisen = 100;
                                getEisen = 25;
                                gold = 1000;
                                getGold = 100;
                                haus = 0;
                                villa = 0;
                                // Gebäude kosten und Rohstoffe addition
                                kostenHausHolz = 300;
                                kostenHausGold = 1500;
                                addHausEisen = 25;
                                addHausGold = 50;
                                kostenVillaEisen = 200;
                                kostenVillaGold = 2000;
                                addVillaHolz = 20;
                                addVillaGold = 150;
                            }
                            do
                            {
                                ResMenue(holz, getHolz, eisen, getEisen, gold, getGold, haus, villa);
                                strEingabe = SpielerBenutzereingabeMenü();
                                Console.Clear();

                                if (strEingabe == "h")
                                {
                                    holz += getHolz;
                                    Console.WriteLine($"Du hast {getHolz} Holz abgebaut");
                                }
                                else if (strEingabe == "e")
                                {
                                    eisen += getEisen;
                                    Console.WriteLine($"Du hast {getEisen} Eisen abgebaut");
                                }
                                else if (strEingabe == "g")
                                {
                                    gold += getGold;
                                    Console.WriteLine($"Du hast {getGold} Gold abgebaut");
                                }
                                else if (strEingabe == "a")
                                {
                                    string resVorhanden = HausMenue(kostenHausHolz, kostenHausGold, addHausEisen, addHausGold);

                                    if (resVorhanden == "y")
                                    {
                                        if (holz >= kostenHausHolz && gold >= kostenHausGold)
                                        {
                                            haus++;
                                            holz -= kostenHausHolz;
                                            gold -= kostenHausGold;
                                            getEisen += addHausEisen;
                                            getGold += addHausGold;
                                            Console.WriteLine("Du hast ein Haus gekauft!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Du hast nicht genug Ressourcen");
                                        }
                                    }
                                    if (resVorhanden == "n")
                                    {
                                        Console.WriteLine("Du bist wieder im Spielmenü");
                                    }
                                }
                                else if (strEingabe == "v")
                                {
                                    string resVorhanden = VillaMenue(kostenVillaEisen, kostenVillaGold, addVillaHolz, addVillaGold);
                                    if (resVorhanden == "y")
                                    {
                                        if (eisen >= kostenVillaEisen && gold >= kostenVillaGold)
                                        {
                                            villa++;
                                            eisen -= kostenVillaEisen;
                                            gold -= kostenVillaGold;
                                            getHolz += addVillaHolz;
                                            getGold += addVillaGold;
                                            Console.WriteLine("Du hast eine Villa gekauft!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Du hast nicht genug Ressourcen");
                                        }
                                    }
                                    if (resVorhanden == "n")
                                    {
                                        Console.WriteLine("Du bist wieder im Spielmenü");
                                    }
                                }

                            } while (strEingabe != "z");



                        }
                        break;
                    case "n":
                        {
                            // Normales Level
                            Console.WriteLine("Aktuell nicht verfügbar!");
                            Benutzereingabe();
                        }
                        break;
                    case "s":
                        {
                            // Schweres Level
                            Console.WriteLine("Aktuell nicht verfügbar!");
                            Benutzereingabe();
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
        }

        // METHODEN
        // Hauptmenü Überschrifft
        static void HauptUeberschrift(float Ver)
        {
            Console.WriteLine($"Version:  {Ver} \n-----------------------------------");
            Console.WriteLine("Willkommen auf einer einsamen Insel");
            Console.WriteLine("-----------------------------------");
        }

        // Hauptmenü Benutzereingaben
        static void HauptBenutzereingaben()
        {
            Console.WriteLine("Wähle dein Level:");
            Console.WriteLine("-----------------");
            Console.WriteLine("Leicht (L), Normal (N), Schwer (S)");
            Console.WriteLine("Credits (C), Info Level (I)");
            Console.WriteLine("Spiel Beenden (B)");
        }

        // Credits Beschreibung
        static void Credits(float Ver)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Remake - Einsame Insel Version " + Ver);
            Console.WriteLine("Concept, Development, Design by Denis Kliem\n\n");
            Console.WriteLine("Copyright 2018 by Denis Kliem");
            Console.WriteLine("-----------------------------------------------");
        }

        // Für die Level Info Beschreibung
        static void LevelInfo()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Level Informationen");
            Console.WriteLine("-------------------");
            Console.WriteLine("Leicht:\n-Für alle die schnell vorankommen möchten!-\n");
            Console.WriteLine("Normal:\n-Upgradekosten sind höher als bei Leicht, Rest gleich.-\n");
            Console.WriteLine("Schwer:\n-Weniger pro Abbau, Upgrades Teurer, Kosten pro Upgrades erhöhen sich stark!-");
        }

        // Zum skippen von Menüs
        static void Benutzereingabe()
        {
            Console.Write("\nZum fortführen, bitte eine Taste drücken.");
            Console.ReadKey();
            Console.Clear();
        }

        // SPIELMENÜ
        // Ressourcen Menü
        static void ResMenue(int holz, int getHolz, int eisen, int getEisen, int gold, int getGold, int haus, int villa)
        {
            Console.WriteLine("----");
            Console.WriteLine("Menü");
            Console.WriteLine("----");
            Console.WriteLine("Momentan hast du:");
            Console.WriteLine($"Holz: {holz}\t Du bekommst pro Abbau:\t {getHolz} Holz");
            Console.WriteLine($"Eisen: {eisen}\t Du bekommst pro Abbau:\t {getEisen} Holz");
            Console.WriteLine($"Gold: {gold}  \t Du bekommst pro Abbau:\t {getGold} Holz");
            Console.WriteLine($"Häuser: {haus}");
            Console.WriteLine($"Villen: {villa}");
        }

        // Spieler Benutzereingabe Menü
        static string SpielerBenutzereingabeMenü()
        {
            Console.WriteLine("\nDu kannst jetzt folgendes tun:");
            Console.WriteLine("Ressourcen:\t Holz abbauen (H), Eisen abbauen (E), Gold Sammeln (G)");
            Console.WriteLine("Gebäude:\t Haus Kaufen (A), Villa kaufen(V)");
            Console.WriteLine("\t\t Zurück ins Hauptmenü (Z)");
            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            return strEingabe;
        }

        // GEBÄUDE MENÜ
        // Haus kaufen
        static string HausMenue(int kostenHausHolz, int kostenHausGold, int addHausEisen, int addHausGold)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Hier kannst du ein Haus Kaufen");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ein Haus kostet:");
            Console.WriteLine($"{kostenHausHolz} Holz");
            Console.WriteLine($"{kostenHausGold} Gold\n");
            Console.WriteLine($"Pro Haus bekommst du beim abbauen von Eisen {addHausEisen} und von Gold {addHausGold} mehr!");
            Console.WriteLine("Haus jetzt kaufen? (Y/N)");

            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            return strEingabe;
        }

        // Villa kaufen
        static string VillaMenue(int kostenVillaEisen, int kostenVillaGold, int addVillaHolz, int addVillaGold)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hier kannst du eine Villa Kaufen");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Eine Villa kostet:");
            Console.WriteLine($"{kostenVillaEisen} Eisen");
            Console.WriteLine($"{kostenVillaGold} Gold\n");
            Console.WriteLine($"Pro Villa bekommst du beim abbauen von Holz {addVillaHolz} und von Gold {addVillaGold} mehr!");
            Console.WriteLine("Villa jetzt kaufen? (Y/N)");

            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            return strEingabe;
        }

    }
}
