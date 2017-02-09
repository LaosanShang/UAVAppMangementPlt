using Ls.Authorization;
using Ls.Components;
using System.Reflection;
using UAV.AppManagePlatform.Domain;

namespace UAV.AppManagePlatform.Application
{
    [DependsOn(typeof(DomainComponent))]
    public class ApplicationComponent : ComponentBase {
        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            if (IocManager.IsRegistered(typeof(IUserStore)))
            {
                IocManager.Release(typeof(IUserStore));
            }
            //Automap 映射初始化
            ApplicationStartUp.AutoMapInit();
        }
    }
}
