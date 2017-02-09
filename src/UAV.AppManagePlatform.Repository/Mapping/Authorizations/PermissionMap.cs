using System.Collections.Generic;
using UAV.AppManagePlatform.Domain.Entities.Authorization;

namespace UAV.AppManagePlatform.Repository.Mapping.Authorization
{
    /// <summary>
    /// 权限映射
    /// </summary>
    public class PermissionMap : BaseEntityTypeConfiguration<Permission>
    {
        public PermissionMap()
        {
            ToTable("Permissions", Schema.Authority);

            this.HasKey(x => x.Id);
            this.Property(x => x.Name)
                .IsRequired();
            this.HasOptional(t => t.Parent)
                .WithMany(t => (IList<Permission>)t.Children)
                .WillCascadeOnDelete(false);
        }
    }
}