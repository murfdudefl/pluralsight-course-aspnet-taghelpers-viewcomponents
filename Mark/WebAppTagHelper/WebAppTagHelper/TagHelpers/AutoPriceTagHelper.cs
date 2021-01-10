using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
	//[HtmlTargetElement("*", Attributes = "make")]
	//[HtmlTargetElement("*", Attributes = "model")]
	//[HtmlTargetElement("*", Attributes = "make, model")]
	//[HtmlTargetElement("*", Attributes = "[make = 'Chevy']")]
	//[HtmlTargetElement("*", Attributes = "[make $= 'evy']")]
	public class AutoPriceTagHelper : TagHelper
	{
		[ViewContext]
		public ViewContext ViewContext { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.Content.SetHtmlContent($"<p>A {Make} {Model} sells for $8.00</p>");
		}
	}
}
