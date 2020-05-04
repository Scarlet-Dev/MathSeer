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
            sb.Append(
                String.Format(
                    $"<label for='{expression}' class={linkAttributes}>{labelText}<a href='{String.Format("/{0}/{1}", authName, actionName)}'>{linkText}<a/></label>"));
            return new HtmlString(sb.ToString());
        }
        
    }
}
