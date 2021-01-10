using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
	// You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
	[HtmlTargetElement("tab-item")]
	public class TabItemTagHelper : TagHelper
	{
		[HtmlAttributeName("title")]
		public string Title { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			var activeLabel = (Title.Equals((string)context.Items["ActivePage"], StringComparison.OrdinalIgnoreCase)) ? " active" : string.Empty;
			output.TagName = "li";
			output.Content.SetHtmlContent($@"<a class='nav-link{activeLabel}' data-toggle='pill' href='#'>{Title}</a>");
		}
	}
}
