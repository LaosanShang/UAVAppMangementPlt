using Newtonsoft.Json;
using System;

namespace UAV.AppManagePlatform.Dto.UI.easyUI
{
    /// <summary>
    /// easy-ui combobox 元素
    /// </summary>
    [Serializable]
    public class ComboboxItem
    {
        /// <summary>
        /// 键
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// 附加信息
        /// </summary>
        public string Attach { get; set; }
    }
}
