using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.Business.Sys.UserManage
{
    public class QueryConditionDto : BaseDto
    {
        [Display(Name = "用户名")]
        public string UserName { get; set; }
        [Display(Name = "真实姓名")]
        public string RealName { get; set; }
        [Display(Name = "角色")]
        public long? RoleId { get; set; }
    }
}
