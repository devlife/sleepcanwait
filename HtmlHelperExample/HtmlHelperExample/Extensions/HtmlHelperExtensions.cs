using System.Web.Mvc;
using HtmlHelperExample.Helpers;

namespace HtmlHelperExample.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IsValidHtmlHelper<TModel> IsValid<TModel>(this HtmlHelper<TModel> helper)
        {
            return new IsValidHtmlHelper<TModel>(helper);
        }
    }
}