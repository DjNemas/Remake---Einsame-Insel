using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake___Einsame_Insel
{
    class OverallText
    {

        // Eingabe Abragen
        public string StrEingabe { get; set; }
        
        // Zum skippen von Menüs
        public void Userinput()
        {
            Console.Write("\nZum fortführen, bitte eine Taste drücken.");
            Console.ReadKey();
            Console.Clear();
        }

        // Falsche Eingabe
        public void BadInput()
        {
            Console.WriteLine("Falsche Eingabe!\nBitte erneut versuchen.");
        }
    }
}
