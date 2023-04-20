using InterfaceDP.structures;

namespace InterfaceDP
{
    public interface ICrudCompte
    {

        public abstract void Insert(SCompte _from);
        public abstract bool Update(SCompte _from);

        public abstract bool Delete(SCompte _from);

        public abstract SCompte? Select(int _id);
    }
}