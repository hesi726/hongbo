using hongbao.CollectionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
#if NET472
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using System.Data.Entity;
using System.Web.Mvc.Html;
#else
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using MvcHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
using IController = Microsoft.AspNetCore.Mvc.Controller;
# endif

namespace hongbao.MvcExtension
{
#if NET472    

    /// <summary>
    /// 脚本和CSS的枚举;
    /// </summary>
    public class EnumBundle
    {
#region 库常量定义
        /// <summary>
        /// JQuery库;
        /// </summary>
        public static EnumBundle JQuery = new EnumBundle
        {
            Name = "JQuery",
            ScriptPath = new string[] { "~/js/plugins/jQueryEasyUI/jquery.min.js" }
        };

        /// <summary>
        /// jQueryEasyUI的脚本和CSS绑定的名称;
        /// </summary>
        public static EnumBundle JQueryEasyUi = new EnumBundle
        {
            Name  = "JQueryEasyUi",
            DependsBundleList = new List<EnumBundle> { JQuery },
            ScriptPath = new string[]
            {
                "~/js/plugins/jQueryEasyUI/jquery.easyui.min.js",
                //datagrid的过滤库,来自http://www.jeasyui.com/demo/main/index.php?plugin=DataGrid&theme=default&dir=ltr&pitem=
                "~/js/plugins/jQueryEasyUI/datagrid-filter.js",  
                "~/js/plugins/jQueryEasyUI/jquery.jdirk.min.js",
                "~/js/plugins/jQueryEasyUI/jeasyui.extensions.all.min.js",
                "~/js/plugins/jQueryEasyUI/config.js"
            },
            StylePath = new string[]
            {
                "~/js/plugins/jQueryEasyUI/themes/bootstrap/easyui.css",
                "~/js/plugins/jQueryEasyUI/themes/icon.css",
                "~/js/plugins/jQueryEasyUI/jeasyui.extensions.min.css",
                "~/js/plugins/jQueryEasyUI/config.css"
            }
        };
#endregion

#region 
        /// <summary>
        /// 依赖的Bundle;
        /// </summary>
        public List<EnumBundle> DependsBundleList { get; set; }

        private string jsBundleName;
        private string cssBundleName;
        private string name;
        private string clientContent = "";
        private string[] scriptPath;
        private string[] stylePath;
        private MvcHtmlString renderHtmlContent = null; 

        /// <summary>
        /// Bundle的名称;
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                cssBundleName = "~/bundles/" + value + "_css";
                jsBundleName  = "~/bundles/" + value;
            }
        }

        /// <summary>
        /// 脚本文件的路径;
        /// </summary>
        public string[] ScriptPath { get { return scriptPath; }
            set
            {
                scriptPath = value;
            }
        }

        /// <summary>
        /// css文件的内容;
        /// </summary>
        public string[] StylePath { get { return stylePath; } set { stylePath = value; } }

        /// <summary>
        /// 注册Bundle;
        /// </summary>
        /// <param name="bundles"></param>
        public  void RegisterBundle(BundleCollection bundles)
        {
            if (StylePath != null && StylePath.Length > 0)
            {
                bundles.Add(new StyleBundle(cssBundleName).Include(StylePath));
            }
            if (ScriptPath != null && ScriptPath.Length > 0)
            {
                bundles.Add(new ScriptBundle(jsBundleName).Include(ScriptPath));
            }            
        }

        /// <summary>
        /// 将脚本的内容输出到客户端;
        /// </summary>
        /// <returns></returns>
        public MvcHtmlString RenderHtmlString()
        {
            if (renderHtmlContent == null)
            {
                var list = new List<string>();
                this.Render(list);
                renderHtmlContent = new HtmlString(list.ToString("\n"));
            }
            return renderHtmlContent;
        }
        
        /// <summary>
        /// 将脚本的内容输出到客户端;
        /// </summary>
        /// <returns></returns>
        private void Render(List<string> contentList = null)
        {
            InitiateClientContent();
            if (contentList==null)
                contentList = new List<string>();
            if (this.DependsBundleList != null)
            {
                foreach (var bundle in DependsBundleList)
                {
                    bundle.Render(contentList);
                }
            }
            contentList.Add(this.clientContent);
        }

        private void InitiateClientContent()
        {
            if (clientContent != null)
            {
                clientContent = "";
                if (StylePath != null && StylePath.Length > 0)
                    clientContent = Styles.Render(cssBundleName).ToString();
                if (ScriptPath != null && ScriptPath.Length > 0)
                    clientContent += Scripts.Render(jsBundleName).ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bundle"></param>
        /// <returns></returns>
        private static string GetBundleName(EnumBundle bundle)
        {
            return "~/bundles/" + bundle.ToString();
        }
#endregion
    }
}
