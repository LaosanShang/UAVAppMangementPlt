using Bifrost.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tts.Framework.Model;
using UAV.AppManagePlatform.Dto.Business.Sys.PermissionManage;
using UAV.AppManagePlatform.Dto.UI;

namespace UAV.AppManagePlatform.Application.ServiceInterfaces.Sys
{
    public interface IPermissionService
    {
        /// <summary>
        /// 获取权限
        /// </summary>
        /// <param name="Id">权限唯一标识</param>
        /// <returns>权限信息</returns>
        PermissionDto GetPermission(long Id);
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="dto">权限信息</param>
        void AddPermission(PermissionDto dto);
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="dto">权限信息</param>
        void DeletePermission(PermissionDto dto);
        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="dto">权限信息</param>
        void ModifyPermission(PermissionDto dto);

        /// <summary>
        /// 查询权限信息
        /// </summary>
        /// <param name="conditionDto">查询条件</param>
        /// <returns>权限信息</returns>
        IList<PermissionDto> QueryPermission(QueryConditionDto conditionDto);

        /// <summary>
        /// 分页查询权限信息
        /// </summary>
        /// <param name="conditionDto">查询条件</param>
        /// <param name="pager">分页信息</param>
        /// <returns>权限信息</returns>
        IList<PermissionDto> QueryPagerPermission(QueryConditionDto conditionDto, Pager pager);
        
    }
}
