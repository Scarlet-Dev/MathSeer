using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MathSeer.UI.Extensions
{
    public class HtmlExtensions
    {
        public static HtmlString LabelWithLink(string expression, string labelText, string linkText, string authName, string actionName, object linkAttributes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<label for='{expression}'>{labelText}<a href='{String.Format("/", authName, actionName)}'>{linkText}<a/></label>");
            return new HtmlString(sb.ToString());
        }
        
    }
}
