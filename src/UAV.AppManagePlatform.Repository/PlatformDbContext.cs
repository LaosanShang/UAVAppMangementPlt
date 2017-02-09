using Ls.Authorization;
using Ls.EntityFramework.UnitOfWork;
using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using UAV.AppManagePlatform.Domain.Entities.Authorization;
using UAV.AppManagePlatform.Repository.Mapping;

namespace UAV.AppManagePlatform.Repository
{
    public class PlatformDbContext : LsDbContext
    {
        public PlatformDbContext()
            : base("conn_debug")
        {
            
        }
        static PlatformDbContext()
        {
            System.Data.Entity.Database.SetInitializer<PlatformDbContext>(null);
        }

        #region Authiorization
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Menu> Menus { get; set; }

        #endregion
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
               type.BaseType.GetGenericTypeDefinition() == typeof(BaseEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
