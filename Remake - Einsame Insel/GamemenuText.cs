using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class GamemenuText
    {
        // SPIELMENÜ
        // Ressourcen Menü
        public void ResMenu(MenuBuilder menuBuilder, Resource res, Buildings building)
        {
            menuBuilder.MenueBuilder("Menü");
            Console.WriteLine("Momentan hast du:");
            Console.WriteLine($"Holz: {res.Holz}/{res.HolzLimit}\t\t Du bekommst pro Abbau:\t {res.GetHolz} Holz");
            Console.WriteLine($"Eisen: {res.Eisen}/{res.EisenLimit}\t\t Du bekommst pro Abbau:\t {res.GetEisen} Holz");
            Console.WriteLine($"Gold: {res.Gold}/{res.GoldLimit}    \t Du bekommst pro Abbau:\t {res.GetGold} Holz");
            Console.WriteLine($"Häuser: {building.Haus}/{building.HausLimit}");
            Console.WriteLine($"Villen: {building.Villa}/{building.VillaLimit}");
        }

        // Spieler Benutzereingabe Menü
        public string SpielerBenutzereingabeMenü(string strEingabe)
        {
            Console.WriteLine("\nDu kannst jetzt folgendes tun:");
            Console.WriteLine("Ressourcen:\t Holz abbauen (H), Eisen abbauen (E), Gold Sammeln (G)");
            Console.WriteLine("Gebäude:\t Haus Kaufen (A), Villa kaufen(V)");
            Console.WriteLine("\t\t Zurück ins Hauptmenü (Z), Spiel Beenden (B)");
            strEingabe = Console.ReadKey().KeyChar.ToString().ToLower();
            return strEingabe;
        }

    }
}
