using Ls;
using Ls.Utilities;
using System.Collections.Generic;
using System.Linq;
using UAV.AppManagePlatform.Application.ServiceInterfaces.Sys;
using UAV.AppManagePlatform.Domain.Entities.Authorization;
using UAV.AppManagePlatform.Domain.Repositories.Authorization;
using UAV.AppManagePlatform.Dto.Business.Sys.RoleManage;

namespace UAV.AppManagePlatform.Application.ServiceImplements.Sys
{
    /// <summary>
    /// 角色领域服务
    /// </summary>
    public class RoleService : BaseApplicationService, IRoleService
    {
        #region 字段
        private readonly IRoleRepository _roleRepository;
        private readonly IPermissionRepository _permissionRepository;
        #endregion

        public RoleService(IRoleRepository roleRepository,
            IPermissionRepository permissionRepository)
        {
            _roleRepository = roleRepository;
            _permissionRepository = permissionRepository;
        }

        /// <summary>
        /// 获取角色信息
        /// </summary>
        /// <param name="Id">角色唯一标识</param>
        /// <returns>角色信息</returns>
        public RoleDto GetRole(long Id)
        {
            Role entity = _roleRepository.Get(Id);
            return entity.ToDto<RoleDto>();
        }
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="dto">传入角色信息</param>
        public void AddRole(RoleDto dto)
        {
            #region 业务验证
            Role role = _roleRepository.Get(t => t.Name == dto.Name);
            if (role != null) throw new LsException(string.Format("角色[{0}]已经存在,请确认！", dto.Name));
            #endregion

            Role entity = dto.ToEntity<Role>();
            _roleRepository.Add(entity);
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="dto">传入角色信息</param>
        public void DeleteRole(RoleDto dto)
        {
            Role entity = _roleRepository.Get(SafeConvert.ToInt64(dto.Id));
            _roleRepository.Delete(entity);
        }
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="dto">传入角色信息</param>
        public void ModifyRole(RoleDto dto)
        {
            Role entity = _roleRepository.Get(SafeConvert.ToInt64(dto.Id));
            entity.Name = dto.Name;
            _roleRepository.Update(entity);
        }
        /// <summary>
        /// 查询角色信息
        /// </summary>
        /// <param name="conditionDto">查询条件</param>
        /// <returns>角色信息</returns>
        public IList<RoleDto> QueryRole(QueryConditionDto conditionDto)
        {
            List<Role> entities = _roleRepository.Query(conditionDto.RoleName);
            return entities.ToListDto<Role, RoleDto>();
        }
        /// <summary>
        /// 分页查询角色信息
        /// </summary>
        /// <param name="conditionDto">查询条件</param>
        /// <param name="pager">分页信息</param>
        /// <returns>分页角色信息</returns>
        public IList<RoleDto> QueryPagerRole(QueryConditionDto conditionDto, Pager pager)
        {
            var entities = _roleRepository.QueryPager(conditionDto.RoleName, pager);
            return entities.ToListDto<Role, RoleDto>();
        }

        /// <summary>
        /// 分配权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="permissionIds"></param>
        public void DistributePermission(long? roleId, long?[] permissionIds)
        {
            Role entity = _roleRepository.Get(SafeConvert.ToInt64(roleId));
            var permissions = _permissionRepository.Table.Where(t => permissionIds.Contains(t.Id));
            entity.Permissions.Clear();
            entity.Permissions = permissions.ToList();
            _roleRepository.Update(entity);

            //WriteOperateLog(LogType.信息, LogModule.权限管理, "角色[{0}]分配权限成功！", entity.RoleName);
        }
    }
}
