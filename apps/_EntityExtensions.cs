using JoySoftware.HomeAssistant.NetDaemon.Common;

namespace Netdaemon.Generated.Extensions
{
    public static partial class EntityExtension
    {
        public static LightEntities LightEx(this NetDaemonApp app) => new LightEntities(app);
        public static SwitchEntities SwitchEx(this NetDaemonApp app) => new SwitchEntities(app);
        public static MediaPlayerEntities MediaPlayerEx(this NetDaemonApp app) => new MediaPlayerEntities(app);
    }

    public partial class LightEntities
    {
        private readonly NetDaemonApp _app;
        public LightEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity HallTak2 => _app.Entity("light.hall_tak2");
        public IEntity ConfigurationTool1 => _app.Entity("light.configuration_tool_1");
        public IEntity Testlampa => _app.Entity("light.testlampa");
        public IEntity HallTak1 => _app.Entity("light.hall_tak1");
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonApp _app;
        public SwitchEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity NetdaemonHouseStateManager => _app.Entity("switch.netdaemon_house_state_manager");
        public IEntity NetdaemonWelcomeHome => _app.Entity("switch.netdaemon_welcome_home");
        public IEntity HallLampa => _app.Entity("switch.hall_lampa");
        public IEntity NetdaemonLightManager => _app.Entity("switch.netdaemon_light_manager");
        public IEntity KokKruka => _app.Entity("switch.kok_kruka");
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonApp _app;
        public MediaPlayerEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IMediaPlayer Vardagsrum => _app.MediaPlayer("media_player.vardagsrum");
    }
}