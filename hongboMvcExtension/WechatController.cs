//using hongbao.WeixinExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if NET472
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using System.Data.Entity;
#else
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
#endif


namespace hongbao.MvcExtension
{
    /// <summary>
    /// 集合了微信一些功能的控制器；
    /// 注意，会自动创建 和 释放 DbContext;
    /// </summary>
    public class WechatController<TDbContext> : AbstractMvcControllerWithDbContext<TDbContext>
        where TDbContext : DbContext
    {
        
        ///// <summary>
        ///// 获取微信JS SDK的票据； 
        ///// </summary>
        ///// <returns></returns>
        //public string getJsTicket()
        //{
        //    return WeixinUtil.GetJsTicket();
        //}

        ///// <summary>
        ///// 获取微信的APPID； 
        ///// </summary>
        ///// <returns></returns>
        //public string getAppId() {
        //    return WeixinUtil.GetAppid();
        //}
    }
}
