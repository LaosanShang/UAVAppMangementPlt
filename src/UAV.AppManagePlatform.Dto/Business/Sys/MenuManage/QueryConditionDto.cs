using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.Business.Sys.MenuManage
{
    public class QueryConditionDto : BaseDto
    {
        [Display(Name = "菜单名称")]
        public string Name { get; set; }

        [Display(Name = "菜单类型")]
        public int? MenuType { get; set; }
    }
}
