using Impostor.Api.Events;
using Impostor.Api.Events.Announcements;
using Impostor.Api.Innersloth;

namespace Impostor.Plugins.AUannounce.Handlers
{
    public class AnnouncementsListener : IEventListener
    {
        private const int Id = 50;

        [EventListener]
        public void OnAnnouncementRequestEvent(IAnnouncementRequestEvent e)
        {
            if (e.Id == Id)
            {
                // Client already has announcement cached, lets just use that
                e.Response.UseCached = true;
            }
            else
            {
                // Client is receiving this announcement for the first time, window will popup 
                e.Response.Announcement = new Announcement(Id, "<align=center><color=#0000FF><size=120%>Thanks for using AUannouce!</size></color></align>\n\n06/10/2021\n\n-Added Announcement Github\n-Added Startup and End Logger\n\n Currenly working on:\n\n-Custom Announcement config\n\nThanks for playing!");
            }
        }
    }
}
