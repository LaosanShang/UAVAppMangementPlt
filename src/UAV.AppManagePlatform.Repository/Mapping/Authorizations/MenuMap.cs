using UAV.AppManagePlatform.Domain.Entities.Authorization;
using UAV.AppManagePlatform.Repository.Mapping;

namespace UAV.AppManagePlatform.Repository.Mapping.Authorization
{
    /// <summary>
    /// 权限映射
    /// </summary>
    public class MenuMap : BaseEntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            ToTable("Menu", Schema.Authority);

            this.HasKey(x => x.Id);
            this.Property(x => x.Name)
                .IsRequired();
        }
    }
}