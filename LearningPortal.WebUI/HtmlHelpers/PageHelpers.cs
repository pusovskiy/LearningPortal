﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using LearningPortal.WebUI.Models;

namespace LearningPortal.WebUI.HtmlHelpers
{
    public static class PageHelpers
    {
        public static MvcHtmlString PageLinks(
            this HtmlHelper html,
            PageInfo pageInfo,
            Func<int, string> pageUrl,
            object htmlAttributes = null)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= pageInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pageInfo.CurrentPage)
                {
                    tag.AddCssClass("btn selected btn-light");
                }
                if (htmlAttributes != null)
                {
                    var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
                    tag.MergeAttributes(attributes);
                }

                result.Append(tag);
            }
            return MvcHtmlString.Create(result.ToString());
        }

    }
}