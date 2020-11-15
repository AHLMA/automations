using NetDaemon.Common;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Extensions
{
    public static partial class EntityExtension
    {
        public static SwitchEntities SwitchEx(this NetDaemonApp app) => new SwitchEntities(app);
        public static LightEntities LightEx(this NetDaemonApp app) => new LightEntities(app);
        public static CameraEntities CameraEx(this NetDaemonApp app) => new CameraEntities(app);
        public static MediaPlayerEntities MediaPlayerEx(this NetDaemonApp app) => new MediaPlayerEntities(app);
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonApp _app;
        public SwitchEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity NetdaemonTv => _app.Entity("switch.netdaemon_tv");
        public IEntity HallLampa => _app.Entity("switch.hall_lampa");
        public IEntity NetdaemonLightManager => _app.Entity("switch.netdaemon_light_manager");
        public IEntity VardagsrumFonsterTv => _app.Entity("switch.vardagsrum_fonster_tv");
        public IEntity KokFonsterlampor => _app.Entity("switch.kok_fonsterlampor");
        public IEntity NetdaemonHouseStateManager => _app.Entity("switch.netdaemon_house_state_manager");
        public IEntity NetdaemonWelcomeHome => _app.Entity("switch.netdaemon_welcome_home");
    }

    public partial class LightEntities
    {
        private readonly NetDaemonApp _app;
        public LightEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity ConfigurationTool1 => _app.Entity("light.configuration_tool_1");
        public IEntity HallTak1 => _app.Entity("light.hall_tak1");
        public IEntity KontoretTak => _app.Entity("light.kontoret_tak");
        public IEntity MellanrummetFonster => _app.Entity("light.mellanrummet_fonster");
        public IEntity KontoretFonster => _app.Entity("light.kontoret_fonster");
        public IEntity HallTak2 => _app.Entity("light.hall_tak2");
        public IEntity MellanrummetTak => _app.Entity("light.mellanrummet_tak");
        public IEntity VardagsrumFonster => _app.Entity("light.vardagsrum_fonster");
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonApp _app;
        public CameraEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public ICamera VikingcamHall => _app.Camera("camera.vikingcam_hall");
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonApp _app;
        public MediaPlayerEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IMediaPlayer Sallskapsrum => _app.MediaPlayer("media_player.sallskapsrum");
        public IMediaPlayer TvVardagsrum => _app.MediaPlayer("media_player.tv_vardagsrum");
        public IMediaPlayer E32pfs640212 => _app.MediaPlayer("media_player.32pfs6402_12");
    }
}