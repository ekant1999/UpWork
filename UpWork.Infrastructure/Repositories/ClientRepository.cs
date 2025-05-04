using Microsoft.EntityFrameworkCore;
using UpWork.Core.Entities.Identity;
using UpWork.Core.Interfaces.Services;
using UpWork.Infrastructure.Data;

namespace UpWork.Infrastructure.Repositories
{
    public class ClientRepository : Repository<ClientUser>, IClientUserRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<ClientUser?> GetByUserIdAsync(string userId)
        {
            return await _dbSet
             .Include(c => c.User)
             .FirstOrDefaultAsync(c => c.UserId == userId);
        }
    }
}
