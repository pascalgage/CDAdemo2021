using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTheathre
{
    public class Piece_de_theatre
    {
		private List<Acte> mes_actes;
		private int dureePieceEnMin;
		private string nomPiece;



        //constructeur par defaut
        //public Piece_de_theatre()
        //{
        //    mes_actes = new List<Acte> { };
        //    dureePieceEnMin = 120;
        //    nomPiece = "Les misérables";
        //}

        //Constructeur classique
        public Piece_de_theatre(List<Acte> mes_actes,int dureePieceEnMin, string nomPiece)
        {
            this.mes_actes = mes_actes;
            this.dureePieceEnMin = dureePieceEnMin;
            this.nomPiece = nomPiece;
        }
        //Constructeur par clonage
        //public Piece_de_theatre(Piece_de_theatre _RecopiePiece)
        //{
        //  duree_piece = _RecopiePiece.duree_piece;
        //	nomPiece = _RecopiePiece.nomPiece;
        //}





        //Constructeur par interdépendance (defaut)
        public Piece_de_theatre()
			: this(new List<Acte>() ,120, "Les misérables")
		{

		}
		//Constructeur par interdépendance (classique)
		//public Piece_de_theatre(int duree_piece, string nomPiece)
		//	: this(duree_piece, nomPiece)
		//{

		//}
		//Constructeur par interdépendance (clonage)
		public Piece_de_theatre(Piece_de_theatre _RecopiePiece)
			: this(_RecopiePiece.mes_actes,_RecopiePiece.dureePieceEnMin, _RecopiePiece.nomPiece)
		{

		}
	}
}
