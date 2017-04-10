using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class PezziTest
    {

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Sesta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiDueCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Quinta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiDueCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Seconda,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Quarta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneBiancoNonPuoMuovereIndietro()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Seconda,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima);

            //Then
            //Assert.True(esito);
            Assert.False(esito);
        }
        
        [Fact]
        public void IlPedoneNeroNonPuoMuovereIndietro()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Ottava);

            //Then
            Assert.False(esito);
        }

        [Fact]
        public void IlCavalloBiancoPuoMuovereL()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        //Then
        }

         [Fact]
        public void IlCavalloBiancoMuoveSoloAdL()
        {
        //Given
        Cavallo cavallo = new Cavallo(Colore.Bianco);
        //When
        bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.B,
                traversaArrivo: Traversa.Terza);

            //Then
            Assert.False(esito);
        //Then
        }

        [Fact]
        public void LaTorreBiancaPuoMuovreInColonna()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.B,
                traversaArrivo: Traversa.Seconda);

            //Then
            Assert.True(esito);
        //Then
        }

        [Fact]
        public void LaTorreBiancaPuoMuovreInTraversa()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Quarta);

            //Then
            Assert.True(esito);
        //Then
        }

        [Fact]
        public void LaTorreBiancaNonPuoMuovreInTraversaEInColonna()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Terza);

            //Then
            Assert.False(esito);
        //Then
        }

        [Fact]
        public void AfierePuoMuovereInDiagonale()
        {
        //Given
        Alfiere alfiere = new Alfiere(Colore.Bianco);
        //When
        bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.C,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.F,
                traversaArrivo: Traversa.Quarta);
            //Then
            Assert.True(esito);
        //Then
        }

        [Fact]
        public void AlfierePuoMuovereSoloInDiagonale()
        {
        //Given
        Torre torre = new Torre(Colore.Bianco);
        //When
        bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Terza);

            //Then
            Assert.False(esito);
        //Then
        }

        //---------------------TEST RE -------------------------------

        [Fact]
        public void ilReBiancoPuoMuovereDiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Quinta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void ilReBiancoPuoMuovereSoloDiUnaCasa()
        {
        //Given
        Re re = new Re(Colore.Bianco);
        //When
        bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Sesta);
        //Then
        Assert.False(esito);
        }
        //--------------------------------------------------------------------
        //----------------------------TEST REGINA-----------------------------
        [Fact]
        public void laReginaPuòMuovereInColonna()
        {
        Regina regina = new Regina(Colore.Bianco);
        //When
        bool esito = regina.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.B,
                traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void laReginaPuòMuovereInTraversa()
        {
        Regina regina = new Regina(Colore.Bianco);
        //When
        bool esito = regina.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Quarta);
        //Then
        Assert.True(esito);
        }
        
        [Fact]
        public void laReginaPuòMuovereInDiagonale()
        {
        Regina regina = new Regina(Colore.Bianco);
        //When
        bool esito = regina.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Sesta);
        //Then
        Assert.True(esito);
        }

        [Fact]
        public void laReginaPuòMuovereSoloInColonnaTraversaDiangonale()
        {
        Regina regina = new Regina(Colore.Bianco);
        //When
        bool esito = regina.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Terza);
        //Then
        Assert.False(esito);
        }
        
    }
}