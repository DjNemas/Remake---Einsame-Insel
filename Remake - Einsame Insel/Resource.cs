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
            this.Holz = 0;
            this.Eisen = 0;
            this.Gold = 0;
            this.GetEisen = 0;
            this.GetHolz = 0;
            this.GetGold = 0;
            this.AddHausEisen = 0;
            this.AddHausGold = 0;
            this.AddVillaHolz = 0;
            this.AddVillaGold = 0;
            this.HolzLimit = 0;
            this.EisenLimit = 0;
            this.GoldLimit = 0;
        }

    }
}
