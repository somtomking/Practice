using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.EmptyWeb.HttpModules
{
    public class ViewModule : IHttpModule
    {
        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(context_BeginRequest);
            context.EndRequest += new EventHandler(context_EndRequest);
        }

        void context_EndRequest(object sender, EventArgs e)
        {
            ((HttpApplication)sender).Context.Response.Write("<h1>请求处理结束后进入自定义Module</h1>");
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            ((HttpApplication)sender).Context.Response.Write("<h1>请求处理开始前进入自定义Module</h1><hr>");
        }
    }
}