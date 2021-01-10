using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppTagHelper.Models;

namespace WebAppTagHelper
{
    public interface ISessionService
    {
        Task<List<Session>> GetSessions(int speakerId, string baseUrl);
    }
}
