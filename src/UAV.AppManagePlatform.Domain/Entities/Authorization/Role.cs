using Ls.Authorization;
using Ls.Domain.Entities;
using System;
using System.Collections.Generic;

namespace UAV.AppManagePlatform.Domain.Entities.Authorization
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role : Entity
    {
        private ICollection<Permission> _permissions;
        public string Name { get; set; }
        public ICollection<Permission> Permissions
        {
            get { return _permissions ?? (_permissions = new List<Permission>()); }
            set { _permissions = value; }
        }
        public string Description { get; set; }
    }
}
