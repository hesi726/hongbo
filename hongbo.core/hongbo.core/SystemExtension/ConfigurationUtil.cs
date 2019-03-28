using System;
using System.Configuration;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 读取配置文件的工具类； 
    /// 使用 ConfigurationManager 类;
    /// </summary>
    public static class ConfigurationUtil
    {       
        /// <summary>
        /// 读取 AppSetting中给定健的内容，如果给定健不存在，返回默认的值； 
        /// </summary>
        /// <param name="key">给定健</param>
        /// <param name="defaultValue">默认的值</param>
        /// <returns></returns>
        public static string AppSetting(string key, string defaultValue = null)
        {
            return AppSetting<string>(key, defaultValue);
        }

        /// <summary>
        /// 读取 AppSetting中给定健的内容，如果给定健不存在，返回默认的值； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">给定健</param>
        /// <param name="defaultValue">默认的值</param>
        /// <returns></returns>
        public static T AppSetting<T>(string key, T  defaultValue=default(T))
        {
            var val = ConfigurationManager.AppSettings[key];
            if (val == null) return defaultValue;
            else return (T) Convert.ChangeType(val, typeof(T));
        }


        

    }
}
