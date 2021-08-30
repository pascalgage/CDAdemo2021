using BiblioTheathre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theâtre
{
    class Program
    {
        static void Main(string[] args)
        {
            Piece_de_theatre maPiece = new Piece_de_theatre();
            
            Scene maScene = new Scene("lmmm",120);

            List<Scene> mesSc=new List<Scene>();
            mesSc.Add(maScene); //
            mesSc.Add(new Scene("scene2", 120));
            mesSc.Add(new Scene("scene3", 110));
            mesSc.Add(new Scene("scene4", 100));

            Acte monActe = new Acte(mesSc, 200, "Folie");
        }
    }
}
