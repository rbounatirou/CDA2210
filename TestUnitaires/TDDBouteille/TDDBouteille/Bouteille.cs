using System.Runtime.CompilerServices;

namespace TDDBouteille
{
    public class Bouteille
    {
        private float contenanceActuelle;
        private float contenanceMaximale;
        private bool estOuverte;

        public float ContenanceActuelle { get => contenanceActuelle; private set => SetValueOfContenanceActuelle(value); }
        public float ContenanceMaximale { get => contenanceMaximale; private set => contenanceMaximale = value; }
        public bool EstOuverte { get => estOuverte; }

        public Bouteille() : this(1.5f, 1.5f, false) { }

        private void SetValueOfContenanceActuelle(float value)
        {
            if (value > contenanceMaximale)
                throw new DebordeException();
            else if (value < 0)
                throw new QuantiteActuelleNegativeException();
            contenanceActuelle = value;
        }

        public Bouteille(float _contenanceActuelle, float _contenanceMaximale, bool _estOuvert)
        {
            if (_contenanceMaximale <= 0)
                throw new ArgumentException("La contenance maximale doit être strictement positive");
            if (_contenanceActuelle < 0)
                throw new ArgumentException("La contenance actuelle ne peut pas etre négative");
            if (_contenanceMaximale < _contenanceActuelle)
                throw new ArgumentException("La contenance actuelle ne peut être supérieure à la contenance maximale");
            this.contenanceMaximale = _contenanceMaximale;
            this.ContenanceActuelle = _contenanceActuelle;            
            this.estOuverte = _estOuvert;
        }

        public bool Ouvrir()
        {
            if (this.estOuverte)
            {
                return false;
            }
            this.estOuverte = true;
            return true;
        }

        public bool Fermer()
        {
            if (!this.estOuverte)
            {
                return false;
            }
            this.estOuverte = false;
            return true;
        }

        public void Vider(float value)
        {
            if (value < 0)
                throw new ArgumentException("La valeur en parametre ne peut pas etre negative");
            if (!estOuverte)
                throw new BottleClosedException("The Vider Function cannot be used on a closed bottle");
            this.ContenanceActuelle -= value;
        }

        public void Remplir(float value)
        {
            if (value < 0)
                throw new ArgumentException("La valeur en parametre ne peut pas etre negative");
            if (!this.estOuverte)
                throw new BottleClosedException("You cannot fill a closed bottle");
            this.ContenanceActuelle += value;
        }

        public void RemplirTout() => Remplir(this.contenanceMaximale-this.ContenanceActuelle);


        public void ViderTout() => Vider(this.ContenanceActuelle);
    }
}