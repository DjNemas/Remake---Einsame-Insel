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
        public int HausLimitAdd { get; set; }
        public int VillaLimitAdd { get; set; }


    }
}
