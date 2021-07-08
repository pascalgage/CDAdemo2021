using Class_libray_421;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TEST_serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            LesJoueurs listeG = new LesJoueurs();
            listeG.AjouterUnJoueur("Tarik", 10255);
            listeG.AjouterUnJoueur("Pascal", 23700);
            listeG.AjouterUnJoueur("POLO", 22500);


            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\1CDA\\CDAdemo2021\\Le_421\\SERIALIZEtest.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, listeG);
            stream.Close();

            stream = new FileStream("C:\\1CDA\\CDAdemo2021\\Le_421\\SERIALIZEtest.txt", FileMode.Open, FileAccess.Read);
            LesJoueurs ListeG = (LesJoueurs)formatter.Deserialize(stream);
            Console.WriteLine(ListeG);

            Console.ReadKey();

        }
    }
}
