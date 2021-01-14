using SoftwareStore.Domain.Repositories.Abstract;

namespace SoftwareStore.Domain
{
    public class DataManager
    {
        public DataManager(
            ICatalogRepository catalogRepository,
            IUsersRepository usersRepository)
        {
            Users = usersRepository;
            Catalog = catalogRepository;
        }

        public ICatalogRepository Catalog { get; }
        public IUsersRepository Users { get; set; }
    }
}
