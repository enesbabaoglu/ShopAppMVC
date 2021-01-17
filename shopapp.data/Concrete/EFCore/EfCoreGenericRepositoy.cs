using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;

namespace shopapp.data.Concrete.EFCore
{
    public class EfCoreGenericRepositoy<Tentity, Tcontext> : IRepository<Tentity>
    where Tentity : class
    where Tcontext : DbContext, new()
    {
        public void Create(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Set<Tentity>().Add(entity);
                db.SaveChanges();
            }
        }
        public void Delete(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Set<Tentity>().Remove(entity);
                db.SaveChanges();
            }
        }

        public List<Tentity> GetAll()
        {
            using (var db = new Tcontext())
            {
                return db.Set<Tentity>().ToList();
            }
        }

        public Tentity GetById(int id)
        {
            using (var db = new Tcontext())
            {
                return db.Set<Tentity>().Find(id);
            }
        }

        public void Update(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}