using System;

namespace Scacchi.Modello.Pezzi {
    public class Cavallo : IPezzo
    {
        private readonly Colore colore;
        public Cavallo(Colore colore)
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
            var distanzaTraLeColonna = Math.Abs((int) colonnaArrivo - (int) colonnaPartenza) ;
            var distanzaTraLeTraverse = Math.Abs((int) traversaArrivo - (int) traversaPartenza);
            
           if((distanzaTraLeColonna == 1 && distanzaTraLeTraverse == 2) || (distanzaTraLeColonna == 2 && distanzaTraLeTraverse == 1)){
               return true;
           }else{
               return false;
           }
        }

    }
}