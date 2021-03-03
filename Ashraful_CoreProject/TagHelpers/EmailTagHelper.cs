using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ashraful_CoreProject.TagHelpers
{
    [HtmlTargetElement("My-Email")]
    public class EmailTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var mailto = MailTo + "@" + "outlook.com";
            output.Attributes.SetAttribute("href", "mailto:" + mailto);
        }
    }
}
