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
            // Erstelle obj für Menütexte
            Resource res = new Resource();
            Buildings building = new Buildings();

            // Ressourcen berechnen
            CalculateResource calculateResource = new CalculateResource();

            // Version
            string strVersion = "Alpha 0.7";

            // Obj vom Menübuilder inizialisieren
            MenuBuilder menuBuilder = new MenuBuilder();

            // Obj für Texte inizieren
            OverallText textOverall = new OverallText();
            MainmenuText textHauptmenu = new MainmenuText();
            GamemenuText textGamemenu = new GamemenuText();
            Buildingmenu textBuilding = new Buildingmenu();

            textHauptmenu.HauptUeberschrift(strVersion, menuBuilder);
            // Schleifen Beginn für das Spiel
            do
            {
                // Hauptmenü Benutzereingabe
                textHauptmenu.HauptBenutzereingaben();

                // Eingabe abfragen
                textOverall.StrEingabe = Console.ReadKey().KeyChar.ToString().ToLower();

                // Menüpunkte
                Console.Clear();
                switch (textOverall.StrEingabe)
                {
                    // LEICHTES LEVEL
                    case "l":
                        {
                            
                            if (neuesLevel == 1)
                            {
                                // Ressourcen und Gebäude Speichern
                                neuesLevel = 2;
                                // Starte Level Leicht                                
                                res = new Resource(100, 100, 1000, 25, 50, 100, 25, 50, 20, 150, 900, 600, 10500);
                                building = new Buildings(0,0,300,1500,200,2000,3,3);
                            }
                            do
                            {                                
                                textGamemenu.ResMenu(menuBuilder, res, building);
                                textOverall.StrEingabe = textGamemenu.SpielerBenutzereingabeMenü(textOverall.StrEingabe);
                                Console.Clear();

                                switch (textOverall.StrEingabe)
                                {
                                    case "h":
                                        {
                                            res.Holz = calculateResource.resAbbauen("Holz", res.Holz, res.HolzLimit, res.GetHolz);
                                        }
                                        break;
                                    case "e":
                                        {
                                            res.Eisen = calculateResource.resAbbauen("Eisen", res.Eisen, res.EisenLimit, res.GetEisen);
                                        }
                                        break;
                                    case "g":
                                        {
                                            res.Gold = calculateResource.resAbbauen("Gold", res.Gold, res.GoldLimit, res.GetGold);
                                        }
                                        break;
                                    case "a":
                                        {
                                            textBuilding.HausKaufenMenue(menuBuilder, textOverall, res, building, calculateResource);
                                        }
                                        break;
                                    case "v":
                                        {
                                            textBuilding.VillaKaufenMenue(menuBuilder, textOverall, res, building, calculateResource);
                                        }
                                        break;
                                    case "b":
                                        {
                                            Environment.Exit(0);
                                        }
                                        break;
                                    default:
                                        {
                                            if (textOverall.StrEingabe != "z")
                                            {
                                               textOverall.BadInput();
                                            }
                                        }
                                        break;
                                }

                            } while (textOverall.StrEingabe != "z");
                        }
                        break;
                    // NORMALES LEVEL
                    case "n":
                        {
                            // Normales Level
                            Console.WriteLine("Aktuell nicht verfügbar!");
                            textOverall.BadInput();
                        }
                        break;
                    // SCHWERES LEVEL
                    case "s":
                        {
                            // Schweres Level
                            Console.WriteLine("Aktuell nicht verfügbar!");
                            textOverall.BadInput();
                        }
                        break;
                    // CREDITS
                    case "c":
                        {
                            textHauptmenu.Credits(strVersion, menuBuilder);
                            textOverall.BadInput();
                        }
                        break;
                    // LEVEL INFO
                    case "i":
                        {
                            textHauptmenu.LevelInfo(menuBuilder);
                            textOverall.BadInput();
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
                            textOverall.BadInput();
                        }
                        break;
                }
            } while (textOverall.StrEingabe != "b");
        }

        

        

        

        
        

    }
}

