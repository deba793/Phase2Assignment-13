﻿using System.Web;
using System.Web.Mvc;

namespace Phase2Assignment_13
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
