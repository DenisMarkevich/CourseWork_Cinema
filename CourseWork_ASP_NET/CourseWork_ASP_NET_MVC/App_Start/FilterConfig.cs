﻿using System.Web;
using System.Web.Mvc;

namespace CourseWork_ASP_NET_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
