﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.TagHelpers
{
	// You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
	// Specifying the target element is not required but adds clarity
	[HtmlTargetElement("speaker-card",
		TagStructure = TagStructure.NormalOrSelfClosing,
		ParentTag = "speaker-track")]
	public class SpeakerCardTagHelper : TagHelper
	{
		public Speaker Speaker { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			var content = $@"<div class='card'>
		                <div class='card-img'><img src='static/speakers/Speaker-{Speaker.SpeakerId}.jpg' /></div>
		                <h4 class='card-title'><a href='#'>{Speaker.UserFirstName} {Speaker.UserLastName}</a></h4>
		                <p class='card-position'>{Speaker.Company}</p>
		                <p class='card-description'>Keynote: Will be announced soon</p>
		                <ul class='social accent-color'>
			                <li>
				                <a target='_blank' href='#'>LinkedIn</a>
			                </li>
			                <li>
				                <a target='_blank' href='#'>Microsoft</a>
			                </li>
		                </ul>
	                </div>";
			output.Attributes.SetAttribute("class", "col-xs-12 col-sm-6 col-md-4 col-lg-3");
			output.TagName = "div";
			output.Content.SetHtmlContent(content);
		}
		
		//public  override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		//{
		//	var content = $@"<div class='card'>
		//                <div class='card-img'><img src='static/speakers/Speaker-{Speaker.SpeakerId}.jpg' /></div>
		//                <h4 class='card-title'><a href='#'>{Speaker.UserFirstName} {Speaker.UserLastName}</a></h4>
		//                <p class='card-position'>{Speaker.Company}</p>
		//                <p class='card-description'>Keynote: Will be announced soon</p>
		//                <ul class='social accent-color'>
		//	                <li>
		//		                <a target='_blank' href='#'>LinkedIn</a>
		//	                </li>
		//	                <li>
		//		                <a target='_blank' href='#'>Microsoft</a>
		//	                </li>
		//                </ul>
	 //               </div>";
		//	output.Attributes.SetAttribute("class", "col-xs-12 col-sm-6 col-md-4 col-lg-3");
		//	output.TagName = "div";
		//	output.Content.SetHtmlContent(content);
		//}
	}
}
