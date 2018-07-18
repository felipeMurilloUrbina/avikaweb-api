using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.DAO
{
    public class Repository<T> where T: class, IObject
    {
        readonly FakeAvikaDB _context = null;
        public Repository(FakeAvikaDB context)
        {
            this._context = context; 
        }
        public async Task<ICollection<T>> Get()
        {
            return this._context.Set<T>().ToList();
        }
        public async Task<int> Save(T TEntity)
        {
            if (TEntity.Id == 0)
            {
               return await Post(TEntity);
            }
            else
            {
                return await Update(TEntity);
            }
        }
        public async Task<int> Delete(T TEntity)
        {
            await Task.Factory.StartNew(async () => {
                _context.Entry<T>(TEntity).State = EntityState.Modified;
                return await _context.SaveChangesAsync();
            });
            return 1;
        }
        public async Task<int> Delete(int id)
        {
            await Task.Factory.StartNew(async () => {
                var tEntity=_context.Set<T>().Find(id);
                _context.Entry<T>(tEntity).State = EntityState.Deleted;
                return await _context.SaveChangesAsync();
            });
            return 1;
        }
        async Task<int> Update(T TEntity)
        {
             await Task.Factory.StartNew(async () => {
                _context.Set<T>();
                _context.Entry<T>(TEntity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return await _context.SaveChangesAsync();
            });
            return 1;
        }
        async Task<int> Post(T TEntity)
        {
            await Task.Factory.StartNew(async() => {
                _context.Set<T>().Add(TEntity);
                return await _context.SaveChangesAsync();
            });
            return 1;
        }
    }
}
