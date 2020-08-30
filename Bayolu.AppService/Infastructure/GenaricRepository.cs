using Bayolu.Domain;
using Bayolu.SharedKernel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bayolu.AppService.Infastructure
{
    public class GenaricRepository<T,TPk> : IGenericRepository<T> where T : BaseEntity<TPk>
    {
        private BayolyDbContext _context = null;
        private DbSet<T> table = null;
        public GenaricRepository(BayolyDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
    }
}
