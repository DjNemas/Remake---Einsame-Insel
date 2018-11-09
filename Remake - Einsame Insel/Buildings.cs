using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class Buildings
    {

        // Buildings
        public int Haus { get; set; }
        public int Villa { get; set; }

        // Cost for buildings
        public int KostenHausHolz { get; set; }
        public int KostenHausGold { get; set; }
        public int KostenVillaEisen { get; set; }
        public int KostenVillaGold { get; set; }

        // Limits
        public int HausLimit { get; set; }
        public int VillaLimit { get; set; }
        public int HausLimitAdd { get; }
        public int VillaLimitAdd { get; }

        public Buildings()
        {
            // Default
        }

        public Buildings(int haus, int villa, int kostenHausHolz, int kostenHausGold, int kostenVillaEisen,
                         int kostenVillaGold, int hausLimit, int villaLimit)
        {
            this.Haus = haus;
            this.Villa = villa;
            this.KostenHausHolz = kostenHausHolz;
            this.KostenHausGold = kostenHausGold;
            this.KostenVillaEisen = kostenVillaEisen;
            this.KostenVillaGold = kostenVillaGold;
            this.HausLimit = hausLimit;
            this.VillaLimit = villaLimit;
            this.HausLimitAdd = 3;
            this.VillaLimitAdd = 3;
        }

    }
}
