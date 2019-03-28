using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hongbao.ScriptExtension;
using hongbao.SystemExtension;

namespace hongbao.IOExtension
{
    /// <summary>
    /// 缓存的JavascriptFile文件内容定义;
    /// 注意，将根据 javascript 文件的内容创建 JavaScirpt 解析后的执行引擎；
    /// </summary>
    public class CacheJavascriptFileContent : CacheFileContent
    {
        /// <summary>
        /// 构造函数;
        /// </summary>
        public CacheJavascriptFileContent() 
        {

        }
        
        /// <summary>
        /// 脚本解析引擎;
        /// </summary>
        public JavaScriptParce Parce { get; private set; }

        /// <summary>
        /// 被父类回调;
        /// </summary>
        /// <param name="content"></param>
        protected override void ValidateContent(string content)
        {
            base.ValidateContent(content);
            Parce = new JavaScriptParce(content);
        }

        /// <summary>
        /// 去掉脚本文件的注释;
        /// </summary>
        /// <returns></returns>
        public override string FormatContent(string content)
        {
            content = content.Replace("/*", "*/", ""); //去掉段注释;
            content = content.Replace("//", "\n", "\n"); //去掉行注释;
            content = content.Replace("//", "\r", "\r"); //去掉行注释;
            return content;
        }

    }
}