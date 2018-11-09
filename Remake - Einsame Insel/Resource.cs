using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class Resource
    {
        // Main Ressource
        public int Holz { get; set; }
        public int Eisen { get; set; }
        public int Gold { get; set; }

        // Ressource per gather
        public int GetEisen { get; set; }
        public int GetHolz { get; set; }
        public int GetGold { get; set; }

        // Gather more ressource after buying a bulding
        // House
        public int AddHausEisen { get; set; }
        public int AddHausGold { get; set; }
        // Villa
        public int AddVillaHolz { get; set; }
        public int AddVillaGold { get; set; }

        // Ressource Limits
        public int HolzLimit { get; set; }
        public int EisenLimit { get; set; }
        public int GoldLimit { get; set; }

        public Resource()
        {
            // Default
        }

        public Resource(int holz, int eisen, int gold, int getEisen, int getHolz,int getGold, int addHausEisen, int addHausGold,
                        int addVillaHolz, int addVillaGold, int holzLimit, int eisenLimit, int goldLimit)
        {
            this.Holz = holz;
            this.Eisen = eisen;
            this.Gold = gold;
            this.GetEisen = getEisen;
            this.GetHolz = getHolz;
            this.GetGold = getGold;
            this.AddHausEisen = addHausEisen;
            this.AddHausGold = addHausGold;
            this.AddVillaHolz = addVillaHolz;
            this.AddVillaGold = addVillaGold;
            this.HolzLimit = holzLimit;
            this.EisenLimit = eisenLimit;
            this.GoldLimit = goldLimit;
        }

    }
}
