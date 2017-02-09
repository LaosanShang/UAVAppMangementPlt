using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using UAV.AppManagePlatform.Domain.Entities.Authorization;

namespace UAV.AppManagePlatform.Repository.Mapping.Authorization
{
    /// <summary>
    /// 用户映射
    /// </summary>
    public class UserMap : BaseEntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Users", Schema.Authority);

            this.Property(x => x.UserName)
                .HasMaxLength(50)
                .IsRequired();
            this.Property(x => x.LoginId)
                .HasMaxLength(50)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("LOGINIDINDEX") { IsUnique = true }))
                .IsRequired();
            this.HasOptional(t => t.Role)
                .WithMany();
        }
    }
}