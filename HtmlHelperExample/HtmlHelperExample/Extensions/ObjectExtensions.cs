﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace HtmlHelperExample.Extensions
{
    public static class ObjectExtensions
    {
        public static IDictionary<string, object> ToDictionary(this object htmlAttributes)
        {
            if (htmlAttributes == null)
                htmlAttributes = new { };

            return new RouteValueDictionary(htmlAttributes);
        }
    }
}