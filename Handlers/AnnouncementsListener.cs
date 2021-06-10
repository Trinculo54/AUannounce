using Impostor.Api.Events;
using Impostor.Api.Events.Announcements;
using Impostor.Api.Innersloth;

namespace Impostor.Plugins.AUannounce.Handlers
{
        public class AnnouncementsListener : IEventListener
    {
        private const int Id = 50;
        private AUannounceSettings settings => AUannounce.settings;

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
                e.Response.Announcement = new Announcement(Id, settings.Announcement);
            }
        }
    }
}
