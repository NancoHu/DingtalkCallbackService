﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DingtalkCallbackService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new Service.WebApiFilters.WebApiErrorHandleAttribute());
        }
    }
}
