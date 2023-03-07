namespace TransactionBibli
{
    public class MaTransaction
    {

        private string nom;
        private double montant;
        private DateTime date;
        private string codePostal;

        public MaTransaction(string nom, double montant, DateTime date, string codePostal)
        {
            this.nom = nom;
            this.montant = montant;
            this.date = date;
            this.codePostal = codePostal;
        }   

        public override string ToString()
        {
            return String.Format("Nom: {0}{4}Date: {1}{4}Montant: {2}{4}Code Postal: {3}",
                this.nom, this.date, this.montant, this.codePostal, Environment.NewLine);
        }
    }
}