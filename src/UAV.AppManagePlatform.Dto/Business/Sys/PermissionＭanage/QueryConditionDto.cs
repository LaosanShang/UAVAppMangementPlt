using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.Business.Sys.PermissionManage
{
    public class QueryConditionDto : BaseDto
    {
        [Display(Name = "权限名称")]
        public string PermissionName { get; set; }
    }
}
