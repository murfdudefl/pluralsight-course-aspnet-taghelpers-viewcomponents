﻿using System.Collections.Generic;

namespace WebAppTagHelper.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Company { get; set; }
        public string TrackName { get; set; }
		public List<Session> Sessions { get; set; }
	}
}