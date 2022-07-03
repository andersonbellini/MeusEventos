using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeusEventos.Domain.Identity;
using MeusEventos.Persistence.Contextos;
using MeusEventos.Persistence.Contratos;

namespace MeusEventos.Persistence
{
    public class UserPersist : GeralPersist, IUserPersist
    {
        private readonly MeusEventosContext _context;

        public UserPersist(MeusEventosContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users
                                 .SingleOrDefaultAsync(user => user.UserName == userName.ToLower());
        }
    }
}