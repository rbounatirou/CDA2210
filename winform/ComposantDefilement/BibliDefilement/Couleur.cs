namespace BibliDefilement
{
    public class Couleur
    {
        private byte red;
        private byte green;
        private byte blue;

        public Couleur(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public Couleur(int r, int g, int b) : this((byte)r,(byte)g,(byte)b){}

        public Couleur(Couleur c) : this(c.red, c.green, c.Blue) { }

        public Couleur() : this(0, 0, 0) { }


        public byte Red { get => red; set => red = value; }
        public byte Green { get => red; set => green = value; }
        public byte Blue { get => red; set => blue = value; }

        
    }
}