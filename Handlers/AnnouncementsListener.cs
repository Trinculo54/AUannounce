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
            if (settings.Enabled == true)
            {
                if (e.Id == Id)
                {
                    e.Response.UseCached = true;
                }
                else
                {
                    e.Response.Announcement = new Announcement(Id, settings.Announcement);
                }
            } else
            {
                e.Response.UseCached = true;
            }
        }
    }
}
