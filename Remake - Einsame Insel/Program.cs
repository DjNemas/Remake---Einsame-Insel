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

        static void Main(string[] args)
        {
            Ressource res = new Ressource();
            Buildings building = new Buildings();

            // Version
            string strVersion = "Alpha 0.7";

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
                                setLevelVariablen(100, 50, 100, 25, 1000, 100, 0, 0, 300, 1500, 25, 50, 200, 2000, 20, 150, 900, 600, 10500, 3, 3, 3, 3, res, building);
                            }
                            do
                            {
                                ResMenue(res, building);
                                strEingabe = SpielerBenutzereingabeMenü();
                                Console.Clear();

                                switch (strEingabe)
                                {
                                    case "h":
                                        {
                                            res.Holz = resAbbauen(res.Holz, res.HolzLimit, res.GetHolz);
                                        }
                                        break;
                                    case "e":
                                        {
                                            res.Eisen = resAbbauen(res.Eisen, res.EisenLimit, res.GetEisen);
                                        }
                                        break;
                                    case "g":
                                        {
                                            res.Gold = resAbbauen(res.Gold, res.GoldLimit, res.GetGold);
                                        }
                                        break;
                                    case "a":
                                        {
                                            HausKaufenMenue(res, building);
                                        }
                                        break;
                                    case "v":
                                        {
                                            VillaKaufenMenue(res, building);
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
        static void setLevelVariablen(int setHolz, int setGetHolz, int setEisen, int setGetEisen, int setGold, int setGetGold, int setHaus, int setVilla,
            int setKostenHausHolz, int setKostenHausGold, int setAddHausEisen, int setAddHausGold, int setKostenVillaEisen, int setKostenVillaGold,
            int setAddVillaHolz, int setAddVillaGold, int setHolzLimit, int setEisenLimit, int setGoldLimit, int setHausLimit, int setVillaLimit,
            int setHausLimitAdd, int setVillaLimitAdd, Ressource res, Buildings building)
        {

            // Ressourcen nicht nochmal neu setzen
            neuesLevel = 2;

            // Ressourcen festlegen
            res.Holz = setHolz;
            res.GetHolz = setGetHolz;
            res.Eisen = setEisen;
            res.GetEisen = setGetEisen;
            res.Gold = setGold;
            res.GetGold = setGetGold;
            building.Haus = setHaus;
            building.Villa = setVilla;
            // Gebäude kosten und Rohstoffe addition
            building.KostenHausHolz = setKostenHausHolz;
            building.KostenHausGold = setKostenHausGold;
            res.AddHausEisen = setAddHausEisen;
            res.AddHausGold = setAddHausGold;
            building.KostenVillaEisen = setKostenVillaEisen;
            building.KostenVillaGold = setKostenVillaGold;
            res.AddVillaHolz = setAddVillaHolz;
            res.AddVillaGold = setAddVillaGold;
            // Limits werden gesetzt
            res.HolzLimit = setHolzLimit;
            res.EisenLimit = setEisenLimit;
            res.GoldLimit = setGoldLimit;
            building.HausLimit = setHausLimit;
            building.VillaLimit = setVillaLimit;
            building.HausLimitAdd = setHausLimitAdd;
            building.VillaLimitAdd = setVillaLimitAdd;
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


        // Villa Menü
        public static void VillaKaufenMenue(Ressource res, Buildings building)
        {
            string resVorhanden = VillaMenue(res, building);
            if (resVorhanden == "y")
            {
                // Villa kaufen ja nein?
                VillaKaufenAbfrage(res, building);
            }
            // Villa kaufen abbruch
            if (resVorhanden == "n")
            {
                Console.WriteLine("Du bist wieder im Spielmenü");
            }
        }
        // Villa kaufen ja nein mit Berechnung
        static void VillaKaufenAbfrage(Ressource res, Buildings building)
        {
            if (res.Eisen >= building.KostenVillaEisen && res.Gold >= building.KostenVillaGold)
            {
                building.Villa++;
                res.Eisen -= building.KostenVillaEisen;
                res.Gold -= building.KostenVillaGold;
                res.GetHolz += res.AddVillaHolz;
                res.GetGold += res.AddVillaGold;
                Console.WriteLine("Du hast eine Villa gekauft!");
            }
            else
            {
                Console.WriteLine("Du hast nicht genug Ressourcen");
            }
        }

        // Haus Menü
        static public void HausKaufenMenue(Ressource res, Buildings building)
        {
            string resVorhanden = HausMenue(res, building);

            if (resVorhanden == "y")
            {
                // Haus kaufen ja nein?
                HausKaufenAbfrage(res, building);
            }
            // Haus kaufen Abbruch
            if (resVorhanden == "n")
            {
                Console.WriteLine("Du bist wieder im Spielmenü");
            }
        }

        // Haus kaufen ja nein mit Berechnung
        static void HausKaufenAbfrage(Ressource res, Buildings building)
        {
            if (res.Holz >= building.KostenHausHolz && res.Gold >= building.KostenHausGold)
            {
                building.Haus++;
                res.Holz -= building.KostenHausHolz;
                res.Gold -= building.KostenHausGold;
                res.GetEisen += res.AddHausEisen;
                res.GetGold += res.AddHausGold;
                building.VillaLimit += building.VillaLimitAdd;
                Console.WriteLine("Du hast ein Haus gekauft!");
            }
            else
            {
                Console.WriteLine("Du hast nicht genug Ressourcen");
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
        static void ResMenue(Ressource res, Buildings building)
        {
            MenueBuilder("Menü");
            Console.WriteLine("Momentan hast du:");
            Console.WriteLine($"Holz: {res.Holz}/{res.HolzLimit}\t\t Du bekommst pro Abbau:\t {res.GetHolz} Holz");
            Console.WriteLine($"Eisen: {res.Eisen}/{res.EisenLimit}\t\t Du bekommst pro Abbau:\t {res.GetEisen} Holz");
            Console.WriteLine($"Gold: {res.Gold}/{res.GoldLimit}    \t Du bekommst pro Abbau:\t {res.GetGold} Holz");
            Console.WriteLine($"Häuser: {building.Haus}/{building.HausLimit}");
            Console.WriteLine($"Villen: {building.Villa}/{building.VillaLimit}");
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
        static string HausMenue(Ressource res, Buildings building)
        {
            MenueBuilder("Hier kannst du ein Haus kaufen");
            Console.WriteLine("Ein Haus kostet:");
            Console.WriteLine($"{building.KostenHausHolz} Holz");
            Console.WriteLine($"{building.KostenHausGold} Gold\n");
            Console.WriteLine($"Pro Haus bekommst du beim abbauen von Eisen {res.AddHausEisen} und von Gold {res.AddHausGold} mehr!");
            Console.WriteLine($"Ausserdem steigt dein Limit der Villen um {building.VillaLimitAdd}");
            Console.WriteLine("Haus jetzt kaufen? (Y/N)");

            string strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            return strEingabe;
        }

        // Villa kaufen
        static string VillaMenue(Ressource res, Buildings building)
        {
            MenueBuilder("Hier kannst du eine Villa kaufen");
            Console.WriteLine("Eine Villa kostet:");
            Console.WriteLine($"{building.KostenVillaEisen} Eisen");
            Console.WriteLine($"{building.KostenVillaGold} Gold\n");
            Console.WriteLine($"Pro Villa bekommst du beim abbauen von Holz {res.AddVillaHolz} und von Gold {res.AddVillaGold} mehr!");
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

