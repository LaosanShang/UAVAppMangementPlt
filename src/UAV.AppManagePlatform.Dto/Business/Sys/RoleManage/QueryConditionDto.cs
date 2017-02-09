using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.Business.Sys.RoleManage
{
    public class QueryConditionDto : BaseDto
    {
        [Display(Name = "角色名称")]
        public string RoleName { get; set; }
    }
}
