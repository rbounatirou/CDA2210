using CerealApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace CerealApi.Db
{
    public class Repository<T> where T : Model
    {
        private DbContext ctx; // ctx = convention de context
        private DbSet<T> items;
        public Repository(DbContext context)
        {
            ctx = context;
            items = ctx.Set<T>();

        }
        public IEnumerable<T> Get() => items.ToList();

        public T? Get(int id) => items.FirstOrDefault(x => x.Id == id);

        public void Post(T value)
        {
            items.Add(value);
            ctx.SaveChanges();
        }
        public bool Put(int id, T value)
        {
            if (Get(value.Id) is T item && item.UpdateFromModel(value))
            {
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public void Delete(int id)
        {
            if (Get(id) is T get)
            {
                items.Remove(get);
                ctx.SaveChanges();
            }
        }

    }
}
