using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_OK
{
    public class Hanoi_Try
    {
        public static void DeplacerPalet(ref string tabOrigine, ref string tabDestination)
        {
            char palet = tabOrigine[0];
            tabOrigine = tabOrigine.Remove(0, 1);
            tabDestination = tabDestination.Insert(0, palet.ToString());

        }

        public static void Transfert(int nombreDePaletADeplacer, ref string origine, ref string destination, ref string intermediaire)
        {

        }
    }
}
