using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using HtmlHelperExample.Extensions;

namespace HtmlHelperExample.Helpers
{
    public sealed class IsValidHtmlHelper<TModel>
    {
        private readonly HtmlHelper<TModel> _helper;

        public IsValidHtmlHelper(HtmlHelper<TModel> helper)
        {
            _helper = helper;
        }

        public MvcHtmlString TextBoxFor<TProperty>(bool isValid, Expression<Func<TModel, TProperty>> expression, object htmlAttributes = null)
        {
            Debug.Assert(expression != null, "expression is null.");

            var div = new TagBuilder("div");
            div.AddCssClass("control-group");

            if (isValid)
            {
                var attributes = htmlAttributes.ToDictionary();
                AddDisabledAttribute(attributes);

                div.InnerHtml = _helper.TextBoxFor<TModel, TProperty>(expression, attributes).ToString();
            }
            else
            {
                div.AddCssClass("error");

                div.InnerHtml = _helper.TextBoxFor(expression, htmlAttributes).ToString();
            }

            return new MvcHtmlString(div.ToString());
        }

        private static IDictionary<string, object> AddDisabledAttribute(IDictionary<string, object> dictionary)
        {
            return AddAttribute(dictionary, "disabled", "disabled");
        }

        private static IDictionary<string, object> AddAttribute(IDictionary<string, object> dictionary, string key, object value)
        {
            if (dictionary.ContainsKey(key))
                dictionary[key] = value;
            else
                dictionary.Add(key, value);

            return dictionary;
        }
    }
}