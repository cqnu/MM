﻿using Newtonsoft.Json;

namespace MM.Common
{
    /// <summary>
    /// 信息模型
    /// </summary>
    public class Info
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app")]
        public string App   { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type")]
        public string Type  { get; set; }

        /// <summary>
        /// 名称(唯一标识，由英文+数字和下划线组成)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = "";

        /// <summary>
        /// 应用标题名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc  { get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// 使用说明
        /// </summary>
        [JsonProperty("help")]
        public string Help  { get; set; }

        /// <summary>
        /// 目录
        /// </summary>
        [JsonProperty("dir")]
        public string Dir   { get; set; }
    }
}
