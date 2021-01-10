using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
	// You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
	[HtmlTargetElement("time-since")]
	public class TimeSinceTagHelper : TagHelper
	{
		private ITimeSinceService _timeService;

		public TimeSinceTagHelper(ITimeSinceService timeService)
		{
			_timeService = timeService;
		}

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.Content.SetHtmlContent(_timeService.FormattedTimeSince());
		}
	}
}
