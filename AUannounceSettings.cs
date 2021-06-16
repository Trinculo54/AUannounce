using System.Collections.Generic;

namespace Impostor.Plugins.AUannounce
{
    class AUannounceSettings
    {
        public string Announcement { get; set; }
        public bool Enabled { get; set; }


        public AUannounceSettings ()
        {
            Announcement = "<align=center><color=#0000FF><size=120%>Thanks for using AUannouce!</size></color></align>\n\n06/14/2021\n\n-Added Custom Announcement config\n-New README and config.json changes\n\nThanks for playing!";
        }
    }
}
