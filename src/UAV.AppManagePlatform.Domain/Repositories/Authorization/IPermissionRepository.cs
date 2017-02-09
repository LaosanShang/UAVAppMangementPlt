using Ls.Domain.Repositories;
using UAV.AppManagePlatform.Domain.Entities.Authorization;

namespace UAV.AppManagePlatform.Domain.Repositories.Authorization
{
    /// <summary>
    /// 权限仓储接口
    /// </summary>
    public interface IPermissionRepository : IRepository<Permission>
    {
        /// <summary>
        /// 查询权限列表
        /// </summary>
        /// <param name="name">权限名称</param>
        /// <returns></returns>
        dynamic QueryPermission(string name = "");
        /// <summary>
        /// 获取权限信息
        /// </summary>
        /// <param name="id">权限id</param>
        /// <returns>权限信息</returns>
        dynamic GetPermission(long id);
    }
}
