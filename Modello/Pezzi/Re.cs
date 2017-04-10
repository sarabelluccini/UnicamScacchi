using System;

namespace Scacchi.Modello.Pezzi {
    public class Re : IPezzo
    {
        private readonly Colore colore;
        public Re(Colore colore)
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
            var differenzaTraLeColonne = Math.Abs((int) colonnaArrivo - (int) colonnaPartenza) ;
            var differenzaTraLeTraverse = Math.Abs((int) traversaArrivo - (int) traversaPartenza) ;
            
           if(differenzaTraLeColonne == 1 && differenzaTraLeTraverse == 1){
               return true;
           }else{
               return false;
           }
        }

    }
}