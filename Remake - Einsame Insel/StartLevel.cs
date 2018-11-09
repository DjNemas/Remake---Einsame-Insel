using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class StartLevel
    {
        public StartLevel (int setHolz, int setGetHolz, int setEisen, int setGetEisen, int setGold, int setGetGold, int setHaus, int setVilla,
            int setKostenHausHolz, int setKostenHausGold, int setAddHausEisen, int setAddHausGold, int setKostenVillaEisen, int setKostenVillaGold,
            int setAddVillaHolz, int setAddVillaGold, int setHolzLimit, int setEisenLimit, int setGoldLimit, int setHausLimit, int setVillaLimit,
            int setHausLimitAdd, int setVillaLimitAdd, Resource res, Buildings building)
        {
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

    }
}
