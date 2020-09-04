

using NetDaemon.Common.Reactive;

namespace Vikingen.Home.Automations
{

    public static class MagnusExtensions
    {
        public static void Tts(this NetDaemonRxApp app, string entityId, string message)
        {
            app.CallService("tts", "google_translate_say", new { entity_id = entityId, message = message });
        }


    }
}