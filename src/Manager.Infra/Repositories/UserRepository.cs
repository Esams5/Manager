using System.Collections.Generic;
using System.Threading.Tasks;
using Manager.Domain.Entities;
using Manager.Infra.Interfaces;
using Manager.Infra.Context;
using Microsoft.EntityFrameworkCore;


namespace Manager.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ManagerContext _context;
        

        public UserRepository(ManagerContext context) : base(context)
        {
            _context = context;
            
        }

        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.Users
                                      .Where(u => u.Email.ToLower() == email.ToLower())
                                      .AsNoTracking()
                                      .ToListAsync();
            return user.FirstOrDefault();

        }

        public async Task<List<User>> SearchByEmail(string email)
        {
            var allUsers = await _context.Users
                                         .Where(u => u.Email.ToLower().Contains(email.ToLower()))
                                         .AsNoTracking()
                                         .ToListAsync();
            return allUsers;
        }

       

        public async Task<List<User>> SearchByName(string name)
        {
            var allUsers = await _context.Users
                                .Where(u => u.Name.ToLower().Contains(name.ToLower()))
                                .AsNoTracking()
                                .ToListAsync();
            return allUsers;
        }
    }
}