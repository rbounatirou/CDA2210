namespace JeuQuatreCentVingtEtUn
{
    public class Partie
    {
        private byte maxJoueurs;
        private byte maxManches;
        private List<Joueur> participants;
        private EnumEtatPartie etatDeLaPartie;
        private List<Manche> manches;

        public Partie(byte nbManches, byte nbMaxJoueurs)
        {
            maxManches = nbManches;
            maxJoueurs = nbMaxJoueurs;
            participants = new();
            manches = new();
            etatDeLaPartie = EnumEtatPartie.EnAttenteDeJoueurs;
        }

        public bool AjouterJoueur(Joueur j)
        {
            if (participants.Count() >= maxJoueurs || etatDeLaPartie != EnumEtatPartie.EnAttenteDeJoueurs)
                return false;
            participants.Add(j);
            return true;

        }

        public bool AjouterJoueurs(List<Joueur> j)
        {
            if (participants.Count() + j.Count() >= maxJoueurs || etatDeLaPartie != EnumEtatPartie.EnAttenteDeJoueurs)
                return false;
            participants.AddRange(j);
            return true;
        }

        private void ModifierLeScore(Joueur _joueurDesigne)
        {
            Manche last = manches.Last();

        }

    }
}