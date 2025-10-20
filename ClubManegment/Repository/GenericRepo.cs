using ClubManegment.DB;
using Microsoft.EntityFrameworkCore;

namespace ClubManegment.Repository
{
    public class GenericRepo <T> : IGeneric<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepo(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task Add(T en)
        {
            await _dbSet.AddAsync(en);
        }

        public async Task Delete(T en)
        {
            _dbSet.Remove(en);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetBy(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(T EN)
        {
            _dbSet.Update(EN);
        }
    }
}
