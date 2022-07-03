using System.Threading.Tasks;
using MeusEventos.Application.Dtos;
using MeusEventos.Persistence.Models;

namespace MeusEventos.Application.Contratos
{
    public interface IPalestranteService
    {
        Task<PalestranteDto> AddPalestrantes(int userId, PalestranteAddDto model);
        Task<PalestranteDto> UpdatePalestrante(int userId, PalestranteUpdateDto model);

        Task<PageList<PalestranteDto>> GetAllPalestrantesAsync(PageParams pageParams, bool includeEventos = false);
        Task<PalestranteDto> GetPalestranteByUserIdAsync(int userId, bool includeEventos = false);
    }
}