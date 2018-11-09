using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class Buildingmenu
    {
        private string resVorhanden;
        private string strEingabe;

        // GEBÄUDE MENÜ
        // Haus kaufen
        public string HausMenue(MenuBuilder menuBuilder, Resource res, Buildings building)
        {
            menuBuilder.MenueBuilder("Hier kannst du ein Haus kaufen");
            Console.WriteLine("Ein Haus kostet:");
            Console.WriteLine($"{building.KostenHausHolz} Holz");
            Console.WriteLine($"{building.KostenHausGold} Gold\n");
            Console.WriteLine($"Pro Haus bekommst du beim abbauen von Eisen {res.AddHausEisen} und von Gold {res.AddHausGold} mehr!");
            Console.WriteLine($"Ausserdem steigt dein Limit der Villen um {building.VillaLimitAdd}");
            Console.WriteLine("Haus jetzt kaufen? (Y/N)");

            strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            return strEingabe;
        }

        // Villa kaufen
        public string VillaMenue(MenuBuilder menuBuilder, Resource res, Buildings building)
        {
            menuBuilder.MenueBuilder("Hier kannst du eine Villa kaufen");
            Console.WriteLine("Eine Villa kostet:");
            Console.WriteLine($"{building.KostenVillaEisen} Eisen");
            Console.WriteLine($"{building.KostenVillaGold} Gold\n");
            Console.WriteLine($"Pro Villa bekommst du beim abbauen von Holz {res.AddVillaHolz} und von Gold {res.AddVillaGold} mehr!");
            Console.WriteLine("Villa jetzt kaufen? (Y/N)");

            strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            return strEingabe;
        }

        // Villa Menü
        public void VillaKaufenMenue(MenuBuilder menuBuilder, OverallText textOverall, Resource res, Buildings building, CalculateResource calculateResource)
        {
            resVorhanden = VillaMenue(menuBuilder, res, building);
            if (resVorhanden == "y")
            {
                // Villa kaufen ja nein?
                calculateResource.VillaKaufenAbfrage(res, building);
            }
            // Villa kaufen abbruch
            if (resVorhanden == "n")
            {
                Console.WriteLine("Du bist wieder im Spielmenü");
            }
        }


        // Haus Menü
        public void HausKaufenMenue(MenuBuilder menuBuilder, OverallText textOverall, Resource res, Buildings building, CalculateResource calculateResource)
        {
            string resVorhanden = HausMenue(menuBuilder, res, building);

            if (resVorhanden == "y")
            {
                // Haus kaufen ja nein?
                calculateResource.HausKaufenAbfrage(res, building);
            }
            // Haus kaufen Abbruch
            if (resVorhanden == "n")
            {
                Console.WriteLine("Du bist wieder im Spielmenü");
            }
        }

    }
}
