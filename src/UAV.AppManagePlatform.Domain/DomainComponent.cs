using Ls.Components;
using System.Reflection;

namespace UAV.AppManagePlatform.Domain
{
    public class DomainComponent : ComponentBase {
        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
