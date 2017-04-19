using System;

namespace Scacchi.Modello.Pezzi {
    public class Pedone : IPezzo
    {
        private readonly Colore colore;
        public Pedone(Colore colore)
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
            Traversa traversaArrivo,
            IScacchiera scacchiera = null)
        {
            var stessaColonna = colonnaPartenza == colonnaArrivo;
            int distanzaTraLeTraverse;
            if(Colore == Colore.Bianco){
            distanzaTraLeTraverse = (int) traversaArrivo - (int) traversaPartenza;
            }else{
            distanzaTraLeTraverse =  (int) traversaPartenza - (int) traversaArrivo;
            }

            if (stessaColonna && distanzaTraLeTraverse == 1){
                return true;
            } else if (stessaColonna && ((distanzaTraLeTraverse == 2 && colore == Colore.Bianco && traversaPartenza == Traversa.Seconda) || (colore == Colore.Nero && traversaPartenza == Traversa.Settima && distanzaTraLeTraverse == -2)) ){ 
                    return true;
            } else{
                return false;
            }


        }
    }
}