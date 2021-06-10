using System.Collections.Generic;

namespace Impostor.Plugins.AUannounce
{
    class AUannounceSettings
    {
        public string Announcement { get; set; }
        public bool Enabled { get; set; }


        public AUannounceSettings ()
        {
            Announcement = "<align=center><color=#0000FF><size=120%>Thanks for using AUannouce!</size></color></align>\n\n06/10/2021\n\n-Added Announcement Github\n-Added Startup and End Logger\n\n Currenly working on:\n\n-Custom Announcement config\n\nThanks for playing!";
        }
    }
}
