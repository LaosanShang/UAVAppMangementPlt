using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.Business
{
    /// <summary>
    /// 分页查询数据传输对象
    /// </summary>
    public class PagerDto : BaseDto
    {
        private string _sort = "id";
        private string _order = "asc";

        #region 请求参数
        /// <summary>
        /// 排序规则
        /// </summary>
        public string order
        {
            get
            {
                if (string.IsNullOrEmpty(_order))
                    _order = "asc";
                return _order;
            }
            set
            {
                _order = value;
            }
        }
        /// <summary>
        /// 排序列名
        /// </summary>
        public string sort
        {
            get
            {
                if (string.IsNullOrEmpty(_sort))
                    _sort = "Id";
                return _sort;
            }
            set
            {
                _sort = value;
            }
        }
        /// <summary>
        /// 页码
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int rows { get; set; }

        #endregion
    }
}
