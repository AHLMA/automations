using NetDaemon.Common;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Extensions
{
    public static partial class EntityExtension
    {
        public static SwitchEntities SwitchEx(this NetDaemonApp app) => new SwitchEntities(app);
        public static MediaPlayerEntities MediaPlayerEx(this NetDaemonApp app) => new MediaPlayerEntities(app);
        public static LightEntities LightEx(this NetDaemonApp app) => new LightEntities(app);
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonApp _app;
        public SwitchEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity NetdaemonLightManager => _app.Entity("switch.netdaemon_light_manager");
        public IEntity NetdaemonTv => _app.Entity("switch.netdaemon_tv");
        public IEntity VardagsrumFonsterTv => _app.Entity("switch.vardagsrum_fonster_tv");
        public IEntity NetdaemonHouseStateManager => _app.Entity("switch.netdaemon_house_state_manager");
        public IEntity HallLampa => _app.Entity("switch.hall_lampa");
        public IEntity KokFonsterlampor => _app.Entity("switch.kok_fonsterlampor");
        public IEntity NetdaemonWelcomeHome => _app.Entity("switch.netdaemon_welcome_home");
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonApp _app;
        public MediaPlayerEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IMediaPlayer TvVardagsrum => _app.MediaPlayer("media_player.tv_vardagsrum");
        public IMediaPlayer E32pfs640212 => _app.MediaPlayer("media_player.32pfs6402_12");
        public IMediaPlayer Sallskapsrum => _app.MediaPlayer("media_player.sallskapsrum");
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
        public IEntity VardagsrumFonster => _app.Entity("light.vardagsrum_fonster");
    }
}