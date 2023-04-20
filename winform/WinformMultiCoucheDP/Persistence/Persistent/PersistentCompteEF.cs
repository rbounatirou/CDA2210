
using InterfaceDP;
using InterfaceDP.structures;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace IHMDP.Persistent
{
    public class PersistentCompteEF : ICrudCompte
    {

        
        public bool Delete(SCompte _from)
        {
            DbJeuContext context = SingletonDbJeuContext.GetInstance();
            context.Comptes.Load();
            Compte? c = FindById(_from.id);
            if (c == null)
                return false;
            context.Comptes.Remove(c);
            context.SaveChanges();
            return true;
        }

        public void Insert(SCompte _from)
        {
            DbJeuContext context = SingletonDbJeuContext.GetInstance();
            context.Comptes.Load();
            Compte c = new();
            c.Id = _from.id;
            c.Pseudo = _from.pseudo;                
            context.Comptes.Add(c);
            context.SaveChanges();
        }

        public SCompte? Select(int _id)
        {
            DbJeuContext context = SingletonDbJeuContext.GetInstance();
            context.Comptes.Load();
            Compte? c = FindById(_id);
            if (c == null)
                return null;
            SCompte structRt;
            structRt.id = c.Id;
            structRt.pseudo = c.Pseudo;
            return structRt;
        }

        public bool Update(SCompte _from)
        {
            DbJeuContext context = SingletonDbJeuContext.GetInstance();
            context.Comptes.Load();
            Compte? c = FindById(_from.id);
            if (c == null || c.Pseudo == _from.pseudo)
                return false;
            c.Pseudo = _from.pseudo;
            context.Comptes.Update(c);
            context.SaveChanges();
            return true;
        }

        private Compte? FindById(int _id) => SingletonDbJeuContext.GetInstance().Comptes.Find(_id);

    }
}
