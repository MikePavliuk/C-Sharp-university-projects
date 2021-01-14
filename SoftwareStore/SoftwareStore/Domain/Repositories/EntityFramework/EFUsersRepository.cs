using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SoftwareStore.Domain.Entities.Users;
using SoftwareStore.Domain.Repositories.Abstract;



namespace SoftwareStore.Domain.Repositories.EntityFramework
{
    public class EFUsersRepository : IUsersRepository
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public EFUsersRepository(
            AppDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IQueryable<AppUser> GetAppUsers()
        {
            return context.Users;
        }

        public async Task DeleteUserAsync(Guid id)
        {
            AppUser entity = await userManager.FindByIdAsync(id.ToString());
            await userManager.DeleteAsync(entity);
        }
    }
}