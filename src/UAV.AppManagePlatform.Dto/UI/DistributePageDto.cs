﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.UI
{
    public class DistributePageDto : Base.BaseDto
    {

        public DistributePageDto()
        {
            LeftNavMenuList = new List<PermissionMenuActionDto>();
            TopNavMenuList = new List<PermissionMenuActionDto>();
            SolidNavMenuList = new List<PermissionMenuActionDto>();
            APIMenuList = new List<PermissionMenuActionDto>();
        }
        /// <summary>
        /// 角色Id
        /// </summary>
        public long? RoleId { get; set; }
        /// <summary>
        /// 左侧导航栏权限列表
        /// </summary>
        public List<PermissionMenuActionDto> LeftNavMenuList { get; set; }
        /// <summary>
        /// 顶部导航栏权限列表
        /// </summary>
        public List<PermissionMenuActionDto> TopNavMenuList { get; set; }
        /// <summary>
        /// 固定导航栏权限列表
        /// </summary>
        public List<PermissionMenuActionDto> SolidNavMenuList { get; set; }
        /// <summary>
        /// API权限列表
        /// </summary>
        public List<PermissionMenuActionDto> APIMenuList { get; set; }
    }
}
