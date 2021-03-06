﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
	// You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
	[RestrictChildren("tab-item")]
	[HtmlTargetElement("tab")]
	public class TabTagHelper : TagHelper
	{
		[HtmlAttributeName("active-page")]
		public string ActivePage { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			context.Items["ActivePage"] = ActivePage;
			output.TagName = "div";
			output.PreContent.SetHtmlContent
			(
				@"<h3>Silicon Valley Code Camp</h3>
				<nav class='navbar navbar-expand-sm bg-light navbar-light'>
				<ul class='nav nav-pills'>"
			);
			output.PostContent.SetHtmlContent("</ul></nav>");
		}
	}
}
