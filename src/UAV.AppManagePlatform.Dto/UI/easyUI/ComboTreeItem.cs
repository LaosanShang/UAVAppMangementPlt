using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.UI.easyUI
{
    /// <summary>
    /// easyui - combotree 元素
    /// </summary>
    public class ComboTreeItem : ComboboxItem
    {
        public ComboTreeItem()
        {
            Children = new List<ComboTreeItem>();
        }
        [JsonProperty("_parentId")]
        public string ParentId { get; set; }
        [JsonProperty("children")]
        public List<ComboTreeItem> Children { get; set; }
    }
}
