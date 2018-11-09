using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class CalculateResource
    {
        // Haus kaufen ja nein mit Berechnung
        public void HausKaufenAbfrage(Resource res, Buildings building)
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

        // Villa kaufen ja nein mit Berechnung
        public void VillaKaufenAbfrage(Resource res, Buildings building)
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

        // Abbau Berechnung
        public int resAbbauen(string ressource, int res, int resLimit, int getRes)
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

            Console.WriteLine($"Du hast {getRes} {ressource} abgebaut");
            return res;
        }
    }
}
