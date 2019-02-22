using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace DynamicFormFields.Extensions
{
    public static class HtmlPrefixScopeExtensions {
        public static IDisposable BeginHtmlFieldPrefixScope(this IHtmlHelper html, string htmlFieldPrefix) 
        {
            return new HtmlFieldPrefixScope(html.ViewData.TemplateInfo, htmlFieldPrefix);
        }

        private class HtmlFieldPrefixScope : IDisposable 
        {

            private readonly TemplateInfo _templateInfo;
            private readonly string _previousHtmlFieldPrefix;

            public HtmlFieldPrefixScope(TemplateInfo templateInfo, string htmlFieldPrefix) 
            {
                _templateInfo = templateInfo;

                _previousHtmlFieldPrefix = templateInfo.HtmlFieldPrefix;
                templateInfo.HtmlFieldPrefix = htmlFieldPrefix;
            }

            public void Dispose() 
            {
                _templateInfo.HtmlFieldPrefix = _previousHtmlFieldPrefix;
            }
        }
    }
}
