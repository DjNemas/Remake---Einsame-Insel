using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class Program
    {
        // Level Variablen
        static int neuesLevel = 1;

        // Ressourcen
        static int holz = 0;
        static int getHolz = 0;
        static int eisen = 0;
        static int getEisen = 0;
        static int gold = 0;
        static int getGold = 0;
        static int haus = 0;
        static int villa = 0;

        // Gebäude
        static int kostenHausHolz = 0;
        static int kostenHausGold = 0;
        static int addHausEisen = 0;
        static int addHausGold = 0;
        static int kostenVillaEisen = 0;
        static int kostenVillaGold = 0;
        static int addVillaHolz = 0;
        static int addVillaGold = 0;

        // Limits
        static int holzLimit = 0;
        static int eisenLimit = 0;
        static int goldLimit = 0;
        static int hausLimit = 0;
        static int villaLimit = 0;
        static int hausLimitAdd = 0;
        static int villaLimitAdd = 0;

        static void Main(string[] args)
        {
            // Version
            string strVersion = "Alpha 0.65";

            // Variablen
            string strEingabe;
            
            // Hauptmenü Überschrift
            HauptUeberschrift(strVersion);

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
                    // LEICHTES LEVEL
                    case "l":
                        {
                            if (neuesLevel == 1)
                            {
                                setLevelVariablen(100, 50, 100, 25, 1000, 100, 0, 0, 300, 1500, 25, 50, 200, 2000, 20, 150, 900, 600, 10500, 3, 3, 3, 3);
                            }
                            do
                            {
                                ResMenue();
                                strEingabe = SpielerBenutzereingabeMenü();
                                Console.Clear();
                                
                                switch (strEingabe)
                                { 
                                    case "h":
                                        {
                                            holz = resAbbauen(holz, holzLimit, getHolz);
                                        }
                                        break;
                                    case "e":
                                        {
                                            eisen = resAbbauen(eisen, eisenLimit, getEisen);
                                        }
                                        break;
                                    case "g":
                                        {
                                            gold = resAbbauen(gold, goldLimit, getGold);
                                        }
                                        break;
                                    case "a":
                                        {
                                            Haus.HausKaufenMenue();
                                        }
                                        break;
                                    case "v":
                                        {
                                            Villa.VillaKaufenMenue();
                                        }
                                        break;
                                    case "b":
                                        {
                                            Environment.Exit(0);
                                        }
                                        break;
                                    default:
                                        {
                                            if (strEingabe != "z")
                                            {
                                                FalscheEingabe();
                                            }
                                            
                                        }
                                        break;
                                }

                            } while (strEingabe != "z");
                        }
                        break;
                    // NORMALES LEVEL
                    case "n":
                        {
                            // Normales Level
                            Console.WriteLine("Aktuell nicht verfügbar!");
                            Benutzereingabe();
                        }
                        break;
                    // SCHWERES LEVEL
                    case "s":
                        {
                            // Schweres Level
                            Console.WriteLine("Aktuell nicht verfügbar!");
                            Benutzereingabe();
                        }
                        break;
                    // CREDITS
                    case "c":
                        {
                            Credits(strVersion);
                            Benutzereingabe();
                        }
                        break;
                    // LEVEL INFO
                    case "i":
                        {
                            LevelInfo();
                            Benutzereingabe();
                        }
                        break;
                    // HI I BIMS DER BEENDER
                    case "b":
                        {
                            //Environment.Exit(0);
                        }
                        break;
                    // FALSCHE EINGABE?
                    default:
                        {
                            FalscheEingabe();
                        }
                        break;
                }
            } while (strEingabe != "b");
        }

        // Variablen für Level Leicht setzen
        private static void setLevelVariablen(int setHolz, int setGetHolz, int setEisen, int setGetEisen, int setGold, int setGetGold, int setHaus, int setVilla,
            int setKostenHausHolz, int setKostenHausGold, int setAddHausEisen, int setAddHausGold, int setKostenVillaEisen, int setKostenVillaGold,
            int setAddVillaHolz, int setAddVillaGold, int setHolzLimit, int setEisenLimit, int setGoldLimit, int setHausLimit, int setVillaLimit,
            int setHausLimitAdd, int setVillaLimitAdd)
        {
            // Ressourcen nicht nochmal neu setzen
            neuesLevel = 2;

            // Ressourcen festlegen
            holz = setHolz;
            getHolz = setGetHolz;
            eisen = setEisen;
            getEisen = setGetEisen;
            gold = setGold;
            getGold = setGetGold;
            haus = setHaus;
            villa = setVilla;
            // Gebäude kosten und Rohstoffe addition
            kostenHausHolz = setKostenHausHolz;
            kostenHausGold = setKostenHausGold;
            addHausEisen = setAddHausEisen;
            addHausGold = setAddHausGold;
            kostenVillaEisen = setKostenVillaEisen;
            kostenVillaGold = setKostenVillaGold;
            addVillaHolz = setAddVillaHolz;
            addVillaGold = setAddVillaGold;
            // Limits werden gesetzt
            holzLimit = setHolzLimit;
            eisenLimit = setEisenLimit;
            goldLimit = setGoldLimit;
            hausLimit = setHausLimit;
            villaLimit = setVillaLimit;
            hausLimitAdd = setHausLimitAdd;
            villaLimitAdd = setVillaLimitAdd;
        }

        // Abbau Berechnung
        static int resAbbauen(int res, int resLimit, int getRes)
        {
            if (res <= resLimit)
            {
                res += getRes;
                if (res > resLimit)
                {
                    res = resLimit;
                    Console.WriteLine("Du hast dein Limit erreicht");
                }
                return res;
            }

            Console.WriteLine($"Du hast {getRes} Holz abgebaut");
            return res;
        }

        // Falsche Eingabe
        static void FalscheEingabe()
        {
            Console.WriteLine("Falsche Eingabe!\nBitte erneut versuchen.");
        }

        class Villa
        {

            // Villa Menü
            public static void VillaKaufenMenue()
            {
                string resVorhanden = VillaMenue();
                if (resVorhanden == "y")
                {
                    // Villa kaufen ja nein?
                    VillaKaufenAbfrage();
                }
                // Villa kaufen abbruch
                if (resVorhanden == "n")
                {
                    Console.WriteLine("Du bist wieder im Spielmenü");
                }
            }
            // Villa kaufen ja nein mit Berechnung
            static void VillaKaufenAbfrage()
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

        }
        class Haus
        {
            // Haus Menü
            static public void HausKaufenMenue()
            {
                string resVorhanden = HausMenue();

                if (resVorhanden == "y")
                {
                    // Haus kaufen ja nein?
                    HausKaufenAbfrage();
                }
                // Haus kaufen Abbruch
                if (resVorhanden == "n")
                {
                    Console.WriteLine("Du bist wieder im Spielmenü");
                }
            }

            // Haus kaufen ja nein mit Berechnung
            static void HausKaufenAbfrage()
            {
                if (holz >= kostenHausHolz && gold >= kostenHausGold)
                {
                    haus++;
                    holz -= kostenHausHolz;
                    gold -= kostenHausGold;
                    getEisen += addHausEisen;
                    getGold += addHausGold;
                    villaLimit += villaLimitAdd;
                    Console.WriteLine("Du hast ein Haus gekauft!");
                }
                else
                {
                    Console.WriteLine("Du hast nicht genug Ressourcen");
                }
            }

        }
        
        // METHODEN
        // Hauptmenü Überschrifft
        static void HauptUeberschrift(string version)
        {
            Console.WriteLine($"Version: {version}");
            MenueBuilder("Willkommen auf der einsamen Insel");
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
        static void Credits(string version)
        {

            ArrayList entries = new ArrayList();
            entries.Add("Remake - Einsame Insel Version " + version);
            entries.Add("Concept, Development, Design by Denis Kliem");
            entries.Add("\n\n");
            entries.Add("Copyright 2018 by Denis Kliem");

            MenueBuilder(entries);            


        }

        // Für die Level Info Beschreibung
        static void LevelInfo()
        {
            MenueBuilder("Level Informationen");
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
        static void ResMenue()
        {
            MenueBuilder("Menü");
            Console.WriteLine("Momentan hast du:");
            Console.WriteLine($"Holz: {holz}/{holzLimit}\t\t Du bekommst pro Abbau:\t {getHolz} Holz");
            Console.WriteLine($"Eisen: {eisen}/{eisenLimit}\t\t Du bekommst pro Abbau:\t {getEisen} Holz");
            Console.WriteLine($"Gold: {gold}/{goldLimit}    \t Du bekommst pro Abbau:\t {getGold} Holz");
            Console.WriteLine($"Häuser: {haus}/{hausLimit}");
            Console.WriteLine($"Villen: {villa}/{villaLimit}");
        }

        // Spieler Benutzereingabe Menü
        static string SpielerBenutzereingabeMenü()
        {
            Console.WriteLine("\nDu kannst jetzt folgendes tun:");
            Console.WriteLine("Ressourcen:\t Holz abbauen (H), Eisen abbauen (E), Gold Sammeln (G)");
            Console.WriteLine("Gebäude:\t Haus Kaufen (A), Villa kaufen(V)");
            Console.WriteLine("\t\t Zurück ins Hauptmenü (Z), Spiel Beenden (B)");
            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            return strEingabe;
        }

        // GEBÄUDE MENÜ
        // Haus kaufen
        static string HausMenue()
        {
            MenueBuilder("Hier kannst du ein Haus kaufen");
            Console.WriteLine("Ein Haus kostet:");
            Console.WriteLine($"{kostenHausHolz} Holz");
            Console.WriteLine($"{kostenHausGold} Gold\n");
            Console.WriteLine($"Pro Haus bekommst du beim abbauen von Eisen {addHausEisen} und von Gold {addHausGold} mehr!");
            Console.WriteLine($"Ausserdem steigt dein Limit der Villen um {villaLimitAdd}");
            Console.WriteLine("Haus jetzt kaufen? (Y/N)");

            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            return strEingabe;
        }

        // Villa kaufen
        static string VillaMenue()
        {
            MenueBuilder("Hier kannst du eine Villa kaufen");
            Console.WriteLine("Eine Villa kostet:");
            Console.WriteLine($"{kostenVillaEisen} Eisen");
            Console.WriteLine($"{kostenVillaGold} Gold\n");
            Console.WriteLine($"Pro Villa bekommst du beim abbauen von Holz {addVillaHolz} und von Gold {addVillaGold} mehr!");
            Console.WriteLine("Villa jetzt kaufen? (Y/N)");

            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            return strEingabe;
        }

        static void MenueBuilder(String title)
        {
            int length = title.Length;
            MenueBuilderLine(length, "-");

            Console.WriteLine(title);

            MenueBuilderLine(length, "-");


        }
        static void MenueBuilder(ArrayList arrayList)
        {
            
            int maxAmountOfCharacter = 0;

            foreach (String s in arrayList)
            {
                if (s.Length > maxAmountOfCharacter)
                {
                    maxAmountOfCharacter = s.Length;
                }

            }
            MenueBuilderLine(maxAmountOfCharacter, "-");

            foreach (String s in arrayList)
            {
                Console.WriteLine(s);
            }
            MenueBuilderLine(maxAmountOfCharacter, "-");
        }


        static void MenueBuilderLine(int length, String character)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }

    }
}

