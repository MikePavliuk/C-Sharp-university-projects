namespace SoftwareStore.Infrastructure.Config
{
    public class ProjectConfiguration
    {
        public static ProjectConfiguration Current;
        public ProjectConfiguration()
        {
            Current = this;
        }

        public GlobalConfiguration Global { get; set; } = new GlobalConfiguration();
        public CompanyConfiguration Company { get; set; } = new CompanyConfiguration();
        public SmtpConfiguration Smtp { get; set; } = new SmtpConfiguration();
        public DatabaseConfiguration Database { get; set; } = new DatabaseConfiguration();
    }

    public class GlobalConfiguration
    {
        public string AuthorName { get; set; }
    }

    public class CompanyConfiguration
    {
        public string CompanyName { get; set; }
    }

    public class SmtpConfiguration
    {
        public string ServerName { get; set; }
        public string ServerPort { get; set; }
        public string UseSsl { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }

    public class DatabaseConfiguration
    {
        public string ConnectionString { get; set; }
    }
}
