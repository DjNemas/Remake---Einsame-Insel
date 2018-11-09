using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Remake___Einsame_Insel
{
    class MainmenuText
    {
        // Hauptmenü Überschrift
        public void HauptUeberschrift(string version, MenuBuilder menuBuilder)
        {
            Console.WriteLine($"Version: {version}");
            menuBuilder.MenueBuilder("Willkommen auf der einsamen Insel");
        }

        // Hauptmenü Benutzereingaben
        public void HauptBenutzereingaben()
        {
            Console.WriteLine("Wähle dein Level:");
            Console.WriteLine("-----------------");
            Console.WriteLine("Leicht (L), Normal (N), Schwer (S)");
            Console.WriteLine("Credits (C), Info Level (I)");
            Console.WriteLine("Spiel Beenden (B)");
        }

        // Credits Beschreibung
        public void Credits(string version, MenuBuilder menuBuilder)
        {

            ArrayList entries = new ArrayList();
            entries.Add("Remake - Einsame Insel Version " + version);
            entries.Add("Concept, Development, Design by Denis Kliem");
            entries.Add("\n\n");
            entries.Add("Copyright 2018 by Denis Kliem");

            menuBuilder.MenueBuilder(entries);
        }

        // Für die Level Info Beschreibung
        public void LevelInfo(MenuBuilder menuBuilder)
        {
            menuBuilder.MenueBuilder("Level Informationen");
            Console.WriteLine("Leicht:\n-Für alle die schnell vorankommen möchten!-\n");
            Console.WriteLine("Normal:\n-Upgradekosten sind höher als bei Leicht, Rest gleich.-\n");
            Console.WriteLine("Schwer:\n-Weniger pro Abbau, Upgrades Teurer, Kosten pro Upgrades erhöhen sich stark!-");
        }
    }
}
