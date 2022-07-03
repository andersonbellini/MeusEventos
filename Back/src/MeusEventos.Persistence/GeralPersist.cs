using System.Threading.Tasks;
using MeusEventos.Persistence.Contextos;
using MeusEventos.Persistence.Contratos;

namespace MeusEventos.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly MeusEventosContext _context;
        public GeralPersist(MeusEventosContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.AddAsync(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}