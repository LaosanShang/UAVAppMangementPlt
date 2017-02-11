using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV.AppManagePlatform.Dto.Business;

namespace UAV.AppManagePlatform.Dto.UI
{
    public class DistributePageDto : BaseDto
    {

        public DistributePageDto()
        {
            //LeftNavMenuList = new List<PermissionMenuActionDto>();
        }
        /// <summary>
        /// 角色Id
        /// </summary>
        public long? RoleId { get; set; }
        /// <summary>
        /// 左侧导航栏权限列表
        /// </summary>
        //public List<PermissionMenuActionDto> LeftNavMenuList { get; set; }
    }
}
