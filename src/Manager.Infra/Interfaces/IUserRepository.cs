using System.Threading.Tasks;
using Manager.Domain.Entities;
using System.Collections.Generic;

namespace Manager.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<User>> SearchByEmail(string email);
        
        Task<List<User>> SearchByName(string name);
    }
}