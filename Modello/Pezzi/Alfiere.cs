using System;

namespace Scacchi.Modello.Pezzi {
    public class Alfiere : IPezzo
    {
        private readonly Colore colore;
        public Alfiere(Colore colore)
        {
            this.colore = colore;    
        }
        public Colore Colore {
            get {
                return colore;
            }
        }
        public bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo)
        {
            var distanzaTraLeColonne = Math.Abs((int) colonnaArrivo - (int) colonnaPartenza );
            var distanzaTraLeTraverse = Math.Abs((int) traversaArrivo - (int) traversaPartenza );
           if((distanzaTraLeColonne == distanzaTraLeTraverse) && distanzaTraLeColonne != 0 ){
               return true;
           }else{
               return false;
           }
        }

    }
}