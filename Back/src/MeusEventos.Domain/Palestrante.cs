using System.Collections.Generic;
using MeusEventos.Domain.Identity;

namespace MeusEventos.Domain
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string MiniCurriculo { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}