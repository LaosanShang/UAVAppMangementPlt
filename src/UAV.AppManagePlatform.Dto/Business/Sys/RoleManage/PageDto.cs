﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.Business.Sys.RoleManage
{
    public class PageDto
    {
        public PageDto()
        {
            QueryForm = new QueryConditionDto();
        }
        public QueryConditionDto QueryForm { get; set; }
    }
}
