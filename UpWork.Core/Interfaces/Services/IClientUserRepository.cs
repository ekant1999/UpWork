using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Interfaces.Services
{
    public interface IClientUserRepository : IRepository<ClientUser>
    {
        Task<ClientUser?> GetByUserIdAsync(string userId);
    }
}
