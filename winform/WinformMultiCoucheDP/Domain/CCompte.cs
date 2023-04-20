using InterfaceDP;
using InterfaceDP.structures;

namespace Domain
{
    public class CCompte
    {
        private SCompte info;
        private ICrudCompte compte;
        public int Id { get => info.id; set => info.id = value;}
        
        public string Pseudo { get => info.pseudo; set => info.pseudo = value; }

        public CCompte(ICrudCompte c)
        {
            compte = c;
        }
        public void Ajouter() => compte.Insert(this.info); 

        public bool Supprimer() => compte.Delete(this.info);

        public bool Selectionner()
        {
            SCompte? s = compte.Select(this.Id);
            if (s != null)
            {
                this.Pseudo = ((SCompte)s).pseudo;
                return true;
            }
            return false;
        }

        public bool Modifier() => compte.Update(this.info);
    }
}