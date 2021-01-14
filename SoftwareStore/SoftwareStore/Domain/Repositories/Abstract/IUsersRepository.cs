using System;
using System.Linq;
using System.Threading.Tasks;
using SoftwareStore.Domain.Entities.Users;

namespace SoftwareStore.Domain.Repositories.Abstract
{
    public interface IUsersRepository
    {
        IQueryable<AppUser> GetAppUsers();
        Task DeleteUserAsync(Guid id);
    }
}