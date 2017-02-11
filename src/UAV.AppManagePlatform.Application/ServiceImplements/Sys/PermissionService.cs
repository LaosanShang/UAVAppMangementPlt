using System;
using System.Collections.Generic;
using UAV.AppManagePlatform.Application.ServiceInterfaces.Sys;
using UAV.AppManagePlatform.Domain.Repositories.Authorization;
using PermissionManage = UAV.AppManagePlatform.Dto.Business.Sys.PermissionManage;
using UAV.AppManagePlatform.Dto.Business.Sys.PermissionManage;
using UAV.AppManagePlatform.Domain.Entities.Authorization;
using Ls.Caching;
using Ls.Utilities;
using Ls.Model;

namespace UAV.AppManagePlatform.Application.ServiceImplements.Sys
{
    /// <summary>
    /// 权限领域服务
    /// </summary>
    public class PermissionService : BaseApplicationService, IPermissionService
    {
        #region 字段
        private readonly IPermissionRepository _permissionRepository;
        private readonly IRoleRepository _roleRepository;
        //private readonly IAutoStore _userStore;
        private readonly ICacheManager _cacheManager;
        #endregion

        public PermissionService(
            IPermissionRepository permissionRepository,
            IRoleRepository roleRepository,
            ICacheManager cacheManager)
        {
            _permissionRepository = permissionRepository;
            _roleRepository = roleRepository;
            _cacheManager = cacheManager;
        }

        /// <summary>
        /// 获取权限信息
        /// </summary>
        /// <param name="Id">权限唯一标识</param>
        /// <returns>权限信息</returns>
        public PermissionManage.PermissionDto GetPermission(long Id)
        {
            dynamic entity = _permissionRepository.GetPermission(Id);
            return AutoMapExtensions.DynamicToDto<PermissionManage.PermissionDto>(entity);
        }
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="dto">传入权限信息</param>
        public void AddPermission(PermissionManage.PermissionDto dto)
        {
            Permission parent = _permissionRepository.Get(SafeConvert.ToInt64(dto.ParentId));
            //entity.Permission.Parent = parent;
            //_permissionExRepository.Add(entity);
        }
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="dto">传入权限信息</param>
        public void DeletePermission(PermissionManage.PermissionDto dto)
        {
            Permission permission = _permissionRepository.Get(SafeConvert.ToInt64(dto.Id));
            _permissionRepository.Delete(permission);
        }
        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="dto">传入权限信息</param>
        public void ModifyPermission(PermissionManage.PermissionDto dto)
        {
            Permission entity = _permissionRepository.Get(SafeConvert.ToInt64(dto.ParentId));
            entity.MenuId = dto.MenuId;
            _permissionRepository.Update(entity);
        }
        /// <summary>
        /// 查询权限信息
        /// </summary>
        /// <param name="conditionDto">查询条件</param>
        /// <returns>权限信息</returns>
        public IList<PermissionManage.PermissionDto> QueryPermission(PermissionManage.QueryConditionDto conditionDto)
        {
            dynamic entities = _permissionRepository.QueryPermission(conditionDto.PermissionName);
            return AutoMapExtensions.ToDynamicListDto<PermissionDto>(entities);
        }
        /// <summary>
        /// 分页查询权限信息
        /// </summary>
        /// <param name="conditionDto">查询条件</param>
        /// <param name="pager">分页信息</param>
        /// <returns>分页权限信息</returns>
        public IList<PermissionDto> QueryPagerPermission(QueryConditionDto conditionDto, Pager pager)
        {
            throw new NotImplementedException();
        }
    }
}
