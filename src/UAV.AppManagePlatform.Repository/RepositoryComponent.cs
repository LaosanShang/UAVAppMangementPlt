using Ls.Components;
using System.Reflection;
using UAV.AppManagePlatform.Domain;

namespace UAV.AppManagePlatform.Repository
{
    [DependsOn(typeof(DomainComponent))]
    public class RepositoryComponent : ComponentBase {
        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
