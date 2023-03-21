using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ProductionLibrary
{
    public class Production
    {

        private int productionActuelle;

        private int productionDemande;
        private EnumVitesseProduction saVitesseProduction;
        private EnumEtatProduction sonEtatProduction;
        private List<bool> productionsActuelles; // Contient la liste des caisse -> true caisse viable false-> caisse defecturuse
        private Thread threadProduction;

        public delegate void Event_OnProductionChanged(Production prod );
        public delegate void Event_OnProductionFinished(Production prod);
        public delegate void Event_OnProductionStopped(Production prod);
        public delegate void Event_OnProductionStarted(Production prod);
        public delegate void Event_OnProductionReloaded(Production prod);
        public delegate void Event_OnProductionStateChanged(Production prod);

        public event Event_OnProductionChanged ProductionActuelleChanged;
        public event Event_OnProductionFinished ProductionFinished;
        public event Event_OnProductionStopped ProductionStopped;
        public event Event_OnProductionStarted ProductionStarted;
        public event Event_OnProductionReloaded ProductionReloaded;
        public event Event_OnProductionStateChanged ProductionStateChanged;

        public bool[] ProductionActuelle { get => productionsActuelles.ToArray(); }
        public int NbProductionActuelleViable { get => productionsActuelles.FindAll(x=>true).Count(); }
        public int NbProductionActuelleNonViable { get => productionsActuelles.FindAll(x=>false).Count(); }

        public int NbProductionActuelleViableDerniereHeure { 
            get => productionsActuelles.GetRange(
                Math.Max(0, productionsActuelles.Count() - (int)VitesseProduction), 
                (int)VitesseProduction).FindAll(x => true).Count();
        }
        public int NbProductionActuelleNonViableDerniereHeure
        {
            get => productionsActuelles.GetRange(
                Math.Max(0, productionsActuelles.Count() - (int)VitesseProduction),
                (int)VitesseProduction).FindAll(x => false).Count();
        }
        public int ProductionDemande { get => productionDemande; }

        public EnumVitesseProduction VitesseProduction { get => saVitesseProduction; }

        public EnumEtatProduction EtatProduction { get => sonEtatProduction; }

        public Production(EnumVitesseProduction vit)
        {
            productionsActuelles = new();
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

            sonEtatProduction = EnumEtatProduction.EN_COURS;
            if (this.ProductionStarted != null)
                this.ProductionStarted(this);
            if (this.ProductionStateChanged != null)
                this.ProductionStateChanged(this);
            threadProduction = new Thread(new ThreadStart(Produire));
            threadProduction.Start();
            return true;
        }

        public bool Continuer()
        {
            if (sonEtatProduction != EnumEtatProduction.EN_PAUSE)
            {
                return false;
            }
            sonEtatProduction = EnumEtatProduction.EN_COURS;
            if (this.ProductionReloaded != null)
                this.ProductionReloaded(this);
            if (this.ProductionStateChanged != null)
                this.ProductionStateChanged(this);
            return true;

        }

        public bool Arreter()
        {
            if (sonEtatProduction != EnumEtatProduction.EN_COURS)
            {
                return false;
            }
            sonEtatProduction = EnumEtatProduction.EN_PAUSE;
            if (this.ProductionStopped != null)
                this.ProductionStopped(this);
            if (this.ProductionStateChanged != null)
                this.ProductionStateChanged(this);
            return true;
        }

        private void Produire()
        {
            while (sonEtatProduction != EnumEtatProduction.FINIE)
            {
                if (sonEtatProduction == EnumEtatProduction.EN_COURS)
                {
                    productionsActuelles.Add(Aleatoire.GetRandomNumber(1, 1000) <= 950);
                    if (this.ProductionStateChanged != null)
                        this.ProductionStateChanged(this);                    
                }
                if (productionActuelle >= productionDemande)
                {
                    sonEtatProduction = EnumEtatProduction.FINIE;
                }
                else
                {
                    Thread.Sleep((int)((3600.0d / (int)saVitesseProduction) * 1000));
                }
            }
            
            if (this.ProductionFinished != null)
                ProductionFinished(this);
            if (this.ProductionStateChanged != null)
                this.ProductionStateChanged(this);
        }




    }
}