using hongbao.privileges;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace hongboPrivilege.Test
{
    [TestClass]
    public class ExecuteContextAuthen_Test
    {
        [TestMethod]
        public void Authen_Admin_Test()
        {
            FilterContext filterContext = null; // new Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext(null, null, null);
            ExecuteContextAuthen authen = new ExecuteContextAuthen(filterContext, new AdminUser());
            Assert.IsTrue(authen.Authen(new DefaultParceAuthenTypeAccordParameterName()) == EnumAuthenResult.Authened, "管理员肯定有权限");
        }

        [TestMethod]
        public void Authen_Noanyprivilege_Test()
        {
            ControllerActionDescriptor controllerActionDescriptor = new ControllerActionDescriptor();
            controllerActionDescriptor.MethodInfo = this.GetType().GetMethod(nameof(QueryUser), BindingFlags.Public | BindingFlags.Instance);

            var actionContext = new ActionContext();
            actionContext.ActionDescriptor = controllerActionDescriptor;
            actionContext.HttpContext = new Mock<HttpContext>().Object;
            actionContext.RouteData = new RouteData();
            var filterContext = new ExceptionContext(actionContext, new List<IFilterMetadata>());

            var authen = new ExecuteContextAuthen(filterContext, new DefaultPrivilegeJudge());
            Assert.IsTrue(authen.Authen(new DefaultParceAuthenTypeAccordParameterName()) == EnumAuthenResult.NotAuthened, "没有任何权限的人访问 QueryUser 时肯定没有权限");
        }


        [TestMethod]
        public void Authen_Withuserqueryprivilege_Test()
        {
            ControllerActionDescriptor controllerActionDescriptor = new ControllerActionDescriptor();
            controllerActionDescriptor.MethodInfo = this.GetType().GetMethod(nameof(QueryUser), BindingFlags.Public | BindingFlags.Instance);

            var actionContext = new ActionContext();
            actionContext.ActionDescriptor = controllerActionDescriptor;
            actionContext.HttpContext = new Mock<HttpContext>().Object;
            actionContext.RouteData = new RouteData();
            var filterContext = new ExceptionContext(actionContext, new List<IFilterMetadata>());

            var authen = new ExecuteContextAuthen(filterContext, new UserWithUserQueryPrivilege());
            Assert.IsTrue(authen.Authen(new DefaultParceAuthenTypeAccordParameterName()) == EnumAuthenResult.Authened, "有用户查询权限的人访问 QueryUser 时允许访问");
        }

        [TestMethod]
        public void Authen_Withusermodifyprivilege_Test()
        {
            ControllerActionDescriptor controllerActionDescriptor = new ControllerActionDescriptor();
            controllerActionDescriptor.MethodInfo = this.GetType().GetMethod(nameof(ModifyUser), BindingFlags.Public | BindingFlags.Instance);

            var actionContext = new ActionContext();
            actionContext.ActionDescriptor = controllerActionDescriptor;
            actionContext.HttpContext = new Mock<HttpContext>().Object;
            actionContext.RouteData = new RouteData();
            var filterContext = new ExceptionContext(actionContext, new List<IFilterMetadata>());

            var authenQuery = new ExecuteContextAuthen(filterContext, new UserWithUserQueryPrivilege());
            Assert.IsTrue(authenQuery.Authen(new DefaultParceAuthenTypeAccordParameterName()) == EnumAuthenResult.NotAuthened, "有用户查询权限的人访问 ModifyUser 时不允许访问");

            var authenModify = new ExecuteContextAuthen(filterContext, new UserWithUserModifyPrivilege());
            Assert.IsTrue(authenModify.Authen(new DefaultParceAuthenTypeAccordParameterName()) == EnumAuthenResult.Authened, "有用户查询权限的人访问 ModifyUser 时不允许访问");
        }

        [AuthenQuery(null)]
        public void QueryUser(string typeName)
        {

        }

        [AuthenModify(null)]
        public void ModifyUser(string typeName)
        {

        }
    }
}
