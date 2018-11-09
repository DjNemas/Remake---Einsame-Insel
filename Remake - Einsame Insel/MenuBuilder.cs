using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Remake___Einsame_Insel
{
    class MenuBuilder
    {
        public void MenueBuilder(String title)
        {
            int length = title.Length;
            MenueBuilderLine(length, "-");

            Console.WriteLine(title);

            MenueBuilderLine(length, "-");


        }
        public void MenueBuilder(ArrayList arrayList)
        {

            int maxAmountOfCharacter = 0;

            foreach (String s in arrayList)
            {
                if (s.Length > maxAmountOfCharacter)
                {
                    maxAmountOfCharacter = s.Length;
                }

            }
            MenueBuilderLine(maxAmountOfCharacter, "-");

            foreach (String s in arrayList)
            {
                Console.WriteLine(s);
            }
            MenueBuilderLine(maxAmountOfCharacter, "-");
        }


        public void MenueBuilderLine(int length, String character)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }

    }
}
