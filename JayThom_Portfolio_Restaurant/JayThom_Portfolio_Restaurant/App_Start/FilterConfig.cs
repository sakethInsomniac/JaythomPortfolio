﻿using System.Web;
using System.Web.Mvc;

namespace JayThom_Portfolio_Restaurant
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
