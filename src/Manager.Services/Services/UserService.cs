using Manager.Services.Interfaces;

namespace Manager.Services.Services
{
    public class UserService : IUserService
    {
        
        private readonly IMapper _mapper;
        
        private readonly IUserRepository _userRepository;
        
        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            
        }

        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            
        }

        public async Task Remove(long id)
        {
            
        }

        public async Task<UserDTO> Get(long id)
        {
            
        }

        public async Task<List<UserDTO>> Get()
        {
            
        }

        public async Task<List<UserDTO>> SearchByName(string name)
        {
            
        }

        public async Task<List<UserDTO>> SearchByEmail(string email)
        {
            
        }

        public async Task<UserDTO> GetByEmail(string email)
        {
            
        }
    }
}