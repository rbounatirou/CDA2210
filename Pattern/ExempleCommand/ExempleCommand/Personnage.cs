namespace ExempleCommand
{

    // LE PERSONNAGE JOUERA LE ROLE DE RECEIVER
    public class Personnage
    {
        // LA POSITION DU JOUEUR EST DETERMINEE PAR SES COORDONEED
        private int x;
        private int y;        
        
        public Personnage(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void DeplacerAGauche(int nbPx)
        {
            this.x -= nbPx;
        }

        public void DeplacerEnHaut(int nbPx)
        {
            this.y -= nbPx;
        }

        public void DeplacerADroite(int nbPx) => DeplacerAGauche(-nbPx);

        public void DeplacerEnBas(int nbPx) => DeplacerEnHaut(-nbPx);
    }
}