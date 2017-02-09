using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV.AppManagePlatform.Dto.Business
{
    [Serializable]
    public class BaseDto
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public long? Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreatedTime { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public string LastUpdatedTime { get; set; }
    }
}
