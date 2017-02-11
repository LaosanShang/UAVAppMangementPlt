using Ls.Authorization;
using Ls.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Domain.Entities.Authorization
{
    /// <summary>
    /// 权限拓展
    /// </summary>
    public class Permission : Entity
    {
        private ICollection<Permission> _children;

        public string Name { get; set; }

        public long? MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        public ICollection<Permission> Children
        {
            get { return _children ?? (_children = new List<Permission>()); }
            set { _children = value; }
        }
        
        public Permission Parent { get; set; }
    }
}
