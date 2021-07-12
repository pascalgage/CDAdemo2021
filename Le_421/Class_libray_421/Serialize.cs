using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Class_libray_421
{
    public class Serialization
    {
        public static void Sauvegarder(List<Joueur> _nomdeListe)
        {
            

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\1CDA\\CDAdemo2021\\Le_421\\SERIALIZEtest.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, _nomdeListe);
            stream.Close();

            
            

        }
        public static List<Joueur> Ouvrir()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream= new FileStream("C:\\1CDA\\CDAdemo2021\\Le_421\\SERIALIZEtest.txt", FileMode.Open, FileAccess.Read);
            List<Joueur> mesJ = (List<Joueur>)formatter.Deserialize(stream);
            stream.Close();
            return mesJ;
        }
    }
}
