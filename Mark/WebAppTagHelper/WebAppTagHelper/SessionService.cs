using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAppTagHelper.Models;

namespace WebAppTagHelper
{
    public class SessionService : ISessionService
    {
        public async Task<List<Session>> GetSessions(int speakerId, string baseUrl)
        {
            var uri = Path.Join(baseUrl, "/api/sessions");
            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(uri);
            var sessions = JsonConvert.DeserializeObject<List<Session>>(result);
            return sessions.Where(s => s.SpeakerId == speakerId).ToList();
        }
    }
}
