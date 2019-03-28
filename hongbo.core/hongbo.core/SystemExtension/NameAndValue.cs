using hongbao.IOExtension;
using hongbao.SystemExtension;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Common
{
    /// <summary>
    /// 名称和值的接口
    /// </summary>
    public interface INameAndValue
    {
        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// 最后修改时间;
        /// </summary>
        DateTime? LastModifyDateTime { get; set; }
    }

    /// <summary>
    /// 名称和值的类;
    /// </summary>
    public class NameAndValue : INameAndValue
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 最后修改时间;
        /// </summary>
        public DateTime? LastModifyDateTime { get; set; }

        /// <summary>
        /// 如果系统bin目录下加载文件
        /// 从Web.Config或者App.Config或者 NameAndValue列表 中获取给定名称值的定义，
        /// 如果没有这些值，返回null;
        /// 优先将从 NameAndValue列表中取值;
        /// </summary>
        /// <param name="name"></param>
        /// <param name="configList"></param>
        /// <returns></returns>
        public static string GetValueFromConfig(string name, List<INameAndValue> configList)
        {
            string result = null;
            INameAndValue config = configList.Where(a => a.Name == name).FirstOrDefault();
            if (config != null) return config.Value;
            result = ConfigurationManager.AppSettings[name];
            return result;
        }

        
    }
}
