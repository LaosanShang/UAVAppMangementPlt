﻿using System.Collections.Generic;
using System.Linq;
using UAV.AppManagePlatform.Dto.UI.easyUI;

namespace UAV.AppManagePlatform.Dto.UI
{
    /// <summary>
    /// EasyUI数据传输实体拓展
    /// </summary>
    public static class DtoExtension
    {
        #region EasyUI Dtos
        /// <summary>
        /// 转化为标准格式的树列表
        /// </summary>
        /// <param name="source">一般格式的树列表</param>
        /// <returns>标准格式的树列表</returns>
        public static List<ComboTreeItem> ToStandardFormatTree(this List<ComboTreeItem> source)
        {
            List<ComboTreeItem> roots = source.Where(t => string.IsNullOrEmpty(t.ParentId)).ToList();
            BuidStandardTree(roots, source);
            return roots;
        }
        /// <summary>
        /// 构建标准树
        /// </summary>
        /// <param name="nodes">节点列表</param>
        /// <param name="source">节点资源</param>
        private static void BuidStandardTree(List<ComboTreeItem> nodes, List<ComboTreeItem> source)
        {
            foreach (var node in nodes)
            {
                var children = source.Where(t => t.ParentId == node.Id).ToList();
                if (children.Count > 0)
                {
                    node.Children = children;
                    BuidStandardTree(node.Children, source);
                }
                else
                    node.Children = null;
            }
        }
        #endregion
        
    }
}
