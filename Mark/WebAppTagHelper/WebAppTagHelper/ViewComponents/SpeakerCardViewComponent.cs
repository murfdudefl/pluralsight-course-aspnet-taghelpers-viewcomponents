using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.ViewComponents
{
    public class SpeakerCardViewComponent : ViewComponent
    {
        private readonly ISessionService _sessionsService;

        public SpeakerCardViewComponent(ISessionService sessionsService)
        {
            _sessionsService = sessionsService;
        }
        public async Task<IViewComponentResult> InvokeAsync(
            Speaker speaker)
        {
            var baseUrl =
                new Uri(Request.GetEncodedUrl()).GetLeftPart(UriPartial.Authority);
            var sessions = await _sessionsService.GetSessions(speaker.SpeakerId, baseUrl);
            speaker.Sessions = sessions;
            return View(speaker);
        }
    }
}