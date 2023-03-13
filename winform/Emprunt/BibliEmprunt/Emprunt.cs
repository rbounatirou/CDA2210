namespace Emprunts
{
    public class Emprunt
    {
        private string nom;
        private double capitalEmprunte;
        private double tauxInteretAnnuel;
        private int dureeRemboursementEnMois;
        private EnumTypeRemboursement typeRemboursement;       




        public Emprunt(double _capitalEmprunte, double _tauxAnnuel, int _dureeRemboursementMois,
            EnumTypeRemboursement _typeRemboursement) :
            this(null, _capitalEmprunte, _tauxAnnuel, _dureeRemboursementMois, _typeRemboursement)
        {
        }

        public Emprunt(string? _nom, double _capitalEmprunte, double _tauxAnnuel, int _dureeRemboursementMois,
            EnumTypeRemboursement _typeRemboursement)
        {

            this.nom = _nom ??= "";
            SetCapitalEmprunte(_capitalEmprunte);
            SetTauxInteretAnnuel(_tauxAnnuel);
            SetMensualite(_dureeRemboursementMois, _typeRemboursement);
        }

        public string Nom { get => nom; }
        public double CapitalEmprunte { get => capitalEmprunte; set => SetCapitalEmprunte(value); }



        public double TauxInteretAnnuel { get => tauxInteretAnnuel; set => SetTauxInteretAnnuel(value); }
        public int DureeRemboursementEnMois { get => dureeRemboursementEnMois; set => SetDureeRembousementMois(value); }
        public EnumTypeRemboursement TypeRemboursement { get => typeRemboursement; set => SetTypeMensualite(value);  }

        public double CalculerMontantTotalRemboursement()
        {
            return capitalEmprunte *
                (tauxInteretAnnuel /
                (1 - Math.Pow((1 + tauxInteretAnnuel), -CalculerNombreRemboursement())));
        }

        public int CalculerNombreRemboursement()
        {
            return dureeRemboursementEnMois / (int)typeRemboursement;
        }

        private void SetTauxInteretAnnuel(double val)
        {
            if (val < 0)
                throw new Exception("Le taux doit être d'au moins 0%");
            tauxInteretAnnuel = val;
        }

        /// <summary>
        /// Permet de definir les mensualite
        /// </summary>
        /// <param name="_dureeRemboursementEnMois"></param>
        /// <param name="_type"></param>
        /// <exception cref="Exception"></exception>
        public void SetMensualite(int _dureeRemboursementEnMois, EnumTypeRemboursement _type)
        {
            if (_dureeRemboursementEnMois < 1)
            {
                throw new Exception("Impossible d'instancier un emprunt avec une duree de remboursement inferieur à 1 mois");
            }
            else if (_dureeRemboursementEnMois % (int)_type != 0)
            {
                throw new Exception("Impossible d'instancier un emprunt dont le type de mensualité et le nombre de mois de remboursement sont incompatibles.");
            }
            dureeRemboursementEnMois = _dureeRemboursementEnMois;
            typeRemboursement = _type;
        }

        private void SetDureeRembousementMois(int _dureeRemboursementEnMois) => SetMensualite(_dureeRemboursementEnMois, this.typeRemboursement);

        private void SetTypeMensualite(EnumTypeRemboursement _type) => SetMensualite(this.dureeRemboursementEnMois, _type);
    
        private void SetCapitalEmprunte(double val)
        {
            if (val < 0)
            {
                throw new Exception("Le capital emprunté ne peut pas être négatif");
            }
            capitalEmprunte = val;
        }
    }
}