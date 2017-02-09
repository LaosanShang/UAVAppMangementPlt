﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV.AppManagePlatform.Dto.Business.Sys.RoleManage;

namespace UAV.AppManagePlatform.Dto.Business.Sys.UserManage
{
    public class UserDto : BaseDto
    {
        public UserDto()
        {
            Role = new RoleDto();
        }
        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "用户名")]
        [Required(ErrorMessage = "请输入用户名")]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [Display(Name = "联系电话")]
        public string Phone { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Display(Name = "真实姓名")]
        public string RealName { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Display(Name = "邮箱")]
        [EmailAddress(ErrorMessage="邮箱格式输入不正确！")]
        public string Email { get; set; }
        [Display(Name = "角色")]
        [Required(ErrorMessage = "请选择角色")]
        public long? RoleId
        {
            get
            {
                return Role.Id;
            }
            set
            {
                Role.Id = value;
            }
        }
        /// <summary>
        /// 角色
        /// </summary>
        public RoleDto Role { get; set; }
    }
}
