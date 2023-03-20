namespace Productions
{
    public class Production
    {
        public int nbUniteProduite;
        private int nbUniteAProduire;
        public int NbUniteProduite { get => nbUniteProduite; set
            {
                nbUniteProduite = value;
                if (QuantityChangedEvent != null)
                    QuantityChangedEvent(this);
            } 
        }



        public delegate void Event_ProductionTermine(Production p);
        public delegate void Event_QuantityChanged(Production p);
        public event Event_ProductionTermine FinishedEvent;
        public event Event_QuantityChanged QuantityChangedEvent;

        public Production()
        {
            this.nbUniteProduite = 0;
            this.nbUniteAProduire = 10;
        }

        public void Produire()
        {
            while (nbUniteProduite < nbUniteAProduire)
            {
                NbUniteProduite++;
                Thread.Sleep(500);
            }
            // La production est termine on avertis
            if (FinishedEvent != null)
                FinishedEvent(this);
        }
    }
}