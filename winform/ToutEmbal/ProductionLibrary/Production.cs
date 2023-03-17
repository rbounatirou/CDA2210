using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProductionLibrary
{
    public class Production
    {

        private int productionActuelle;

        private int productionDemande;
        private EnumVitesseProduction saVitesseProduction;
        private EnumEtatProduction sonEtatProduction;
        private int saProductionActuelle;

        public delegate void DelegateProduction(Production prod);
        public event DelegateProduction ProductionActuelleChanged;

        public int ProductionActuelle { get => productionActuelle;  }

        public int ProductionDemande { get => productionDemande; }

        public EnumVitesseProduction VitesseProduction { get => saVitesseProduction;  }

        public EnumEtatProduction EtatProduction { get => sonEtatProduction;  }

        public Production(EnumVitesseProduction vit)
        {
            saVitesseProduction = vit;
            switch (vit)
            {
                case EnumVitesseProduction.CAISSE_A:
                    productionDemande = 10000;
                    break;
                case EnumVitesseProduction.CAISSE_B:
                    productionDemande = 25000;
                    break;
                case EnumVitesseProduction.CAISSE_C:
                    productionDemande = 120000;
                    break;
            }
            sonEtatProduction = EnumEtatProduction.NON_DEMARRE;
        }

        public bool Demarrer()
        {
            if (sonEtatProduction != EnumEtatProduction.NON_DEMARRE)
                return false;
            else
            {
                sonEtatProduction = EnumEtatProduction.EN_COURS;

                return true;
            }
                
        }

        public void changerProd()
        {
           productionActuelle++;
            if (ProductionActuelleChanged != null)
            this.ProductionActuelleChanged(this);
        }
        public bool Continuer()
        {
            if (sonEtatProduction != EnumEtatProduction.EN_PAUSE)
            {
                return false;
            } else
            {
                sonEtatProduction = EnumEtatProduction.EN_COURS;
                // PRODUIRE
                return true;
            }
        }

        /*public bool Arreter()
        {

        }*/

        private void Produire()
        {
            while (sonEtatProduction == EnumEtatProduction.EN_COURS)
            {
                
            }
        }

        private void ChangeProductionActuelle(int nb)
        {
            saProductionActuelle = nb;
            // NOTIFY
        }



    }
}