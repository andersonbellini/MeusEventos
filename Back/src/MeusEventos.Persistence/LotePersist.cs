using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeusEventos.Domain;
using MeusEventos.Persistence.Contextos;
using MeusEventos.Persistence.Contratos;

namespace MeusEventos.Persistence
{
    public class LotePersist : ILotePersist
    {
        private readonly MeusEventosContext _context;
        public LotePersist(MeusEventosContext context)
        {
            _context = context;
        }

        public async Task<Lote> GetLoteByIdsAsync(int eventoId, int id)
        {
            IQueryable<Lote> query = _context.Lotes;

            query = query.AsNoTracking()
                         .Where(lote => lote.EventoId == eventoId
                                     && lote.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Lote[]> GetLotesByEventoIdAsync(int eventoId)
        {
            IQueryable<Lote> query = _context.Lotes;

            query = query.AsNoTracking()
                         .Where(lote => lote.EventoId == eventoId);

            return await query.ToArrayAsync();
        }
    }
}