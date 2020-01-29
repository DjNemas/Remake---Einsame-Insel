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
        static int holz;
        static int getHolz;
        static int eisen;
        static int getEisen;
        static int gold;
        static int getGold;
        static int haus;
        static int villa;

        // Res Limit
        static int holzLimit;
        static int holzLimitPruefung;
        static int eisenLimit;
        static int eisenLimitPruefung;
        static int goldLimit;
        static int goldLimitPruefung;

        // Gebäude
        static int kostenHausHolz;
        static int kostenHausGold;
        static int addHausEisen;
        static int addHausGold;
        static int kostenVillaEisen;
        static int kostenVillaGold;
        static int addVillaHolz;
        static int addVillaGold;

        // Zusatzgebäude
        static int lagerHaus;
        

        static void Main(string[] args)
        {
            // Version
            string strVersion = "Alpha 0.8";

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
                strEingabe = EingabeAbfragen();
                

                // Menüpunkte
                Console.Clear();
                switch (strEingabe)
                {
                    // LEICHTES LEVEL
                    case "l":
                        {
                            if (neuesLevel == 3 || neuesLevel == 4)
                            {
                                strEingabe = BeginneNeuesLevel();
                                if (strEingabe == "y")
                                {
                                    neuesLevel = 1;
                                }
                                else if (strEingabe == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    FalscheEingabe();
                                    break;
                                }
                            }

                            if (neuesLevel == 1)
                            {
                                // Ressourcen nicht noch einmal neu setzen
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
                                lagerHaus = 0;
                                // Gebäude kosten und Rohstoffe addition
                                kostenHausHolz = 300;
                                kostenHausGold = 1500;
                                addHausEisen = 25;
                                addHausGold = 50;
                                kostenVillaEisen = 200;
                                kostenVillaGold = 2000;
                                addVillaHolz = 20;
                                addVillaGold = 150;

                                //Res Limit setzen
                                holzLimit = 500;
                                holzLimitPruefung = holzLimit - getHolz;
                                eisenLimit = 300;
                                eisenLimitPruefung = eisenLimit - getEisen;
                                goldLimit = 5000;
                                goldLimitPruefung = goldLimit - getGold;
                            }
                            do
                            {
                                Console.WriteLine("Level Leicht");
                                ResMenue(holz, getHolz, eisen, getEisen, gold, getGold, haus, villa, holzLimit, eisenLimit, goldLimit);
                                strEingabe = SpielerBenutzereingabeMenü();
                                Console.Clear();

                                switch (strEingabe)
                                { 
                                    case "h":
                                        {
                                            HolzLimitPruefung();                                     
                                            Console.WriteLine($"Du hast {getHolz} Holz abgebaut");
                                        }
                                        break;
                                    case "e":
                                        {
                                            EisenLimitPruefung();
                                            Console.WriteLine($"Du hast {getEisen} Eisen abgebaut");
                                        }
                                        break;
                                    case "g":
                                        {
                                            GoldLimitPruefung();
                                            Console.WriteLine($"Du hast {getGold} Gold abgebaut");
                                        }
                                        break;
                                    case "a":
                                        {
                                            Haus.HausKaufenMenue(kostenHausHolz, kostenHausGold, addHausEisen, addHausGold);
                                        }
                                        break;
                                    case "v":
                                        {
                                            Villa.VillaKaufenMenue(kostenVillaEisen, kostenVillaGold, addVillaHolz, addVillaGold);
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
                            if (neuesLevel == 2 || neuesLevel == 4)
                            {
                                strEingabe = BeginneNeuesLevel();
                                if (strEingabe == "y")
                                {
                                    neuesLevel = 1;
                                }
                                else if (strEingabe == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    FalscheEingabe();
                                    break;
                                }
                            }    
                                if (neuesLevel == 1)
                                {
                                    // Ressourcen nicht noch einmal neu setzen
                                    neuesLevel = 3;

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
                                    kostenHausHolz = 600;
                                    kostenHausGold = 3000;
                                    addHausEisen = 25;
                                    addHausGold = 50;
                                    kostenVillaEisen = 400;
                                    kostenVillaGold = 4000;
                                    addVillaHolz = 20;
                                    addVillaGold = 150;

                                    //Res Limit setzen
                                    holzLimit = 10000;
                                    eisenLimit = 10000;
                                    goldLimit = 10000;

                            }
                                do
                                {
                                    Console.WriteLine("Level Normal");
                                    ResMenue(holz, getHolz, eisen, getEisen, gold, getGold, haus, villa, holzLimit, eisenLimit, goldLimit);
                                    strEingabe = SpielerBenutzereingabeMenü();
                                    Console.Clear();

                                    switch (strEingabe)
                                    {
                                        case "h":
                                            {
                                                holz += getHolz;
                                                Console.WriteLine($"Du hast {getHolz} Holz abgebaut");
                                            }
                                            break;
                                        case "e":
                                            {
                                                eisen += getEisen;
                                                Console.WriteLine($"Du hast {getEisen} Eisen abgebaut");
                                            }
                                            break;
                                        case "g":
                                            {
                                                gold += getGold;
                                                Console.WriteLine($"Du hast {getGold} Gold abgebaut");
                                            }
                                            break;
                                        case "a":
                                            {
                                                Haus.HausKaufenMenue(kostenHausHolz, kostenHausGold, addHausEisen, addHausGold);
                                            }
                                            break;
                                        case "v":
                                            {
                                                Villa.VillaKaufenMenue(kostenVillaEisen, kostenVillaGold, addVillaHolz, addVillaGold);
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
                    // SCHWERES LEVEL
                    case "s":
                        {
                            if (neuesLevel == 2 || neuesLevel == 3)
                            {
                                strEingabe = BeginneNeuesLevel();
                                if (strEingabe == "y")
                                {
                                    neuesLevel = 1;
                                }
                                else if (strEingabe == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    FalscheEingabe();
                                    break;
                                }
                            }

                            if (neuesLevel == 1)
                            {
                                // Ressourcen nicht noch einmal neu setzen
                                neuesLevel = 4;

                                // Ressourcen festlegen
                                holz = 100;
                                getHolz = 20;
                                eisen = 100;
                                getEisen = 15;
                                gold = 1000;
                                getGold = 50;
                                haus = 0;
                                villa = 0;
                                // Gebäude kosten und Rohstoffe addition
                                kostenHausHolz = 900;
                                kostenHausGold = 4500;
                                addHausEisen = 10;
                                addHausGold = 20;
                                kostenVillaEisen = 600;
                                kostenVillaGold = 6000;
                                addVillaHolz = 10;
                                addVillaGold = 30;

                                //Res Limit setzen
                                holzLimit = 10000;
                                eisenLimit = 10000;
                                goldLimit = 10000;
                            }
                            do
                            {
                                Console.WriteLine("Level Schwer");
                                ResMenue(holz, getHolz, eisen, getEisen, gold, getGold, haus, villa, holzLimit, eisenLimit, goldLimit);
                                strEingabe = SpielerBenutzereingabeMenü();
                                Console.Clear();

                                switch (strEingabe)
                                {
                                    case "h":
                                        {
                                            holz += getHolz;
                                            Console.WriteLine($"Du hast {getHolz} Holz abgebaut");
                                        }
                                        break;
                                    case "e":
                                        {
                                            eisen += getEisen;
                                            Console.WriteLine($"Du hast {getEisen} Eisen abgebaut");
                                        }
                                        break;
                                    case "g":
                                        {
                                            gold += getGold;
                                            Console.WriteLine($"Du hast {getGold} Gold abgebaut");
                                        }
                                        break;
                                    case "a":
                                        {
                                            Haus.HausKaufenMenue(kostenHausHolz, kostenHausGold, addHausEisen, addHausGold);
                                        }
                                        break;
                                    case "v":
                                        {
                                            Villa.VillaKaufenMenue(kostenVillaEisen, kostenVillaGold, addVillaHolz, addVillaGold);
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
                            Environment.Exit(0);
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

        // Berechnung für Lager Limit Holz
        static void HolzLimitPruefung()
        {
            if (holz >= holzLimit)
            {
                Console.WriteLine("Du hast dein Limit erreicht");
            }
            else if (holzLimitPruefung <= holz)
            {
                holz = holzLimit;
            }
            else
            {
                holz += getHolz;
            }
        }

        // Berechnung für Lager Limit Eisen
        static void EisenLimitPruefung()
        {
            if (eisen >= eisenLimit)
            {
                Console.WriteLine("Du hast dein Limit erreicht");
            }
            else if (eisenLimitPruefung <= eisen)
            {
                eisen = eisenLimit;
            }
            else
            {
                eisen += getEisen;
            }
        }

        // Berechnung für Lager Limit Eisen
        static void GoldLimitPruefung()
        {
            if (gold >= goldLimit)
            {
                Console.WriteLine("Du hast dein Limit erreicht");
            }
            else if (goldLimitPruefung <= gold)
            {
                gold = goldLimit;
            }
            else
            {
                gold += getGold;
            }
        }

        private static string BeginneNeuesLevel()
        {
            MenueBuilder("!!!ACHTUNG!!!");
            Console.WriteLine("Du befindest dich bereits in einem Spiel! Wenn du jetzt dein Level wechselst, geht dein Fortschritt verloren!");
            Console.WriteLine("Wenn du wirklich ein neues Level beginnen willst, kannst du mit (Y) fortfahren. Mit (N) kommst du zum Hauptmenü zurück.");
            string strEingabe = EingabeAbfragen();
            Console.Clear();
            return strEingabe;
        }

        private static string EingabeAbfragen()
        {
            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            return strEingabe;
        }

        // Falsche Eingabe
        static void FalscheEingabe()
        {
            Console.WriteLine("Falsche Eingabe!\nBitte erneut versuchen.\n");
        }

        class Villa
        {

            // Villa Menü
            public static void VillaKaufenMenue(int kostenVillaEisen, int kostenVillaGold, int addVillaHolz, int addVillaGold)
            {
                string resVorhanden = VillaMenue(kostenVillaEisen, kostenVillaGold, addVillaHolz, addVillaGold);
                if (resVorhanden == "y")
                {
                    // Villa kaufen ja nein?
                    VillaKaufenAbfrage(kostenVillaEisen, kostenVillaGold, addVillaHolz, addVillaGold);
                }
                // Villa kaufen abbruch
                if (resVorhanden == "n")
                {
                    Console.WriteLine("Du bist wieder im Spielmenü");
                }
            }
            // Villa kaufen ja nein mit Berechnung
            static void VillaKaufenAbfrage(int kostenVillaEisen, int kostenVillaGold, int addVillaHolz, int addVillaGold)
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
            static public void HausKaufenMenue(int kostenHausHolz, int kostenHausGold, int addHausEisen, int addHausGold)
            {
                string resVorhanden = HausMenue(kostenHausHolz, kostenHausGold, addHausEisen, addHausGold);

                if (resVorhanden == "y")
                {
                    // Haus kaufen ja nein?
                    HausKaufenAbfrage(kostenHausHolz, kostenHausGold, addHausEisen, addHausGold);
                }
                // Haus kaufen Abbruch
                if (resVorhanden == "n")
                {
                    Console.WriteLine("Du bist wieder im Spielmenü");
                }
            }

            // Haus kaufen ja nein mit Berechnung
            static void HausKaufenAbfrage(int kostenHausHolz, int kostenHausGold, int addHausEisen, int addHausGold)
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
            entries.Add("\nFeedback an denis_kliem@yahoo.de\n");
            entries.Add("Copyright 2018-2020 by Denis Kliem");

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
        static void ResMenue(int holz, int getHolz, int eisen, int getEisen, int gold, int getGold, int haus, int villa, int holzLimit, int eisenLimit, int goldLimit)
        {
            MenueBuilder("Menü");
            Console.WriteLine("Momentan hast du:");
            Console.WriteLine($"Holz: {holz} / {holzLimit}  \t Du bekommst pro Abbau:\t {getHolz} Holz");
            Console.WriteLine($"Eisen: {eisen} / {eisenLimit}\t Du bekommst pro Abbau:\t {getEisen} Eisen");
            Console.WriteLine($"Gold: {gold} / {goldLimit}\t Du bekommst pro Abbau:\t {getGold} Gold");
            Console.WriteLine($"Häuser: {haus}");
            Console.WriteLine($"Villen: {villa}");
        }

        // Spieler Benutzereingabe Menü
        static string SpielerBenutzereingabeMenü()
        {
            Console.WriteLine("\nDu kannst jetzt folgendes tun:");
            Console.WriteLine("Ressourcen:\t Holz abbauen (H), Eisen abbauen (E), Gold Sammeln (G)");
            Console.WriteLine("Gebäude:\t Haus Kaufen (A), Villa kaufen(V)");
            Console.WriteLine("\t\t Zurück ins Hauptmenü (Z), Spiel Beenden (B)");
            string strEingabe = EingabeAbfragen();
            return strEingabe;
        }

        // GEBÄUDE MENÜ
        // Haus kaufen
        static string HausMenue(int kostenHausHolz, int kostenHausGold, int addHausEisen, int addHausGold)
        {
            MenueBuilder("Hier kannst du ein Haus kaufen");
            Console.WriteLine("Ein Haus kostet:");
            Console.WriteLine($"{kostenHausHolz} Holz");
            Console.WriteLine($"{kostenHausGold} Gold\n");
            Console.WriteLine($"Pro Haus bekommst du beim abbauen von Eisen {addHausEisen} und von Gold {addHausGold} mehr!");
            Console.WriteLine("Haus jetzt kaufen? (Y/N)");

            string strEingabe = EingabeAbfragen();
            Console.Clear();
            return strEingabe;
        }

        // Villa kaufen
        static string VillaMenue(int kostenVillaEisen, int kostenVillaGold, int addVillaHolz, int addVillaGold)
        {
            MenueBuilder("Hier kannst du eine Villa kaufen");
            Console.WriteLine("Eine Villa kostet:");
            Console.WriteLine($"{kostenVillaEisen} Eisen");
            Console.WriteLine($"{kostenVillaGold} Gold\n");
            Console.WriteLine($"Pro Villa bekommst du beim abbauen von Holz {addVillaHolz} und von Gold {addVillaGold} mehr!");
            Console.WriteLine("Villa jetzt kaufen? (Y/N)");

            string strEingabe = EingabeAbfragen();
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

