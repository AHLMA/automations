using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Reactive
{
    public class GeneratedAppBase : NetDaemonRxApp
    {
        public MediaPlayerEntities MediaPlayer => new MediaPlayerEntities(this);
        public SwitchEntities Switch => new SwitchEntities(this);
        public WeatherEntities Weather => new WeatherEntities(this);
        public BinarySensorEntities BinarySensor => new BinarySensorEntities(this);
        public InputSelectEntities InputSelect => new InputSelectEntities(this);
        public LightEntities Light => new LightEntities(this);
        public PersistentNotificationEntities PersistentNotification => new PersistentNotificationEntities(this);
        public SensorEntities Sensor => new SensorEntities(this);
        public NetdaemonEntities Netdaemon => new NetdaemonEntities(this);
        public SunEntities Sun => new SunEntities(this);
        public PersonEntities Person => new PersonEntities(this);
        public ZoneEntities Zone => new ZoneEntities(this);
    }

    public partial class MediaPlayerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public MediaPlayerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void VolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_up", serviceData);
        }

        public void VolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_down", serviceData);
        }

        public void MediaPlayPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play_pause", serviceData);
        }

        public void MediaPlay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play", serviceData);
        }

        public void MediaPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_pause", serviceData);
        }

        public void MediaStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_stop", serviceData);
        }

        public void MediaNextTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_next_track", serviceData);
        }

        public void MediaPreviousTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_previous_track", serviceData);
        }

        public void ClearPlaylist(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "clear_playlist", serviceData);
        }

        public void VolumeSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_set", serviceData);
        }

        public void VolumeMute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_mute", serviceData);
        }

        public void MediaSeek(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_seek", serviceData);
        }

        public void SelectSource(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_source", serviceData);
        }

        public void SelectSoundMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_sound_mode", serviceData);
        }

        public void PlayMedia(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "play_media", serviceData);
        }

        public void ShuffleSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "shuffle_set", serviceData);
        }
    }

    public partial class SwitchEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SwitchEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class WeatherEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public WeatherEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class BinarySensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public BinarySensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputSelectEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputSelectEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_select", "reload", serviceData);
        }

        public void SelectOption(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_option", serviceData);
        }

        public void SelectNext(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_next", serviceData);
        }

        public void SelectPrevious(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_previous", serviceData);
        }

        public void SetOptions(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "set_options", serviceData);
        }
    }

    public partial class LightEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public LightEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class PersistentNotificationEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public PersistentNotificationEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Create(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("persistent_notification", "create", serviceData);
        }

        public void Dismiss(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("persistent_notification", "dismiss", serviceData);
        }

        public void MarkRead(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("persistent_notification", "mark_read", serviceData);
        }
    }

    public partial class SensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class NetdaemonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public NetdaemonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class SunEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SunEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class PersonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public PersonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("person", "reload", serviceData);
        }
    }

    public partial class ZoneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ZoneEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zone", "reload", serviceData);
        }
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonRxApp _app;
        public MediaPlayerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public MediaPlayerEntity Sallskapsrum => new MediaPlayerEntity(_app, new string[]{"media_player.sallskapsrum"});
        public MediaPlayerEntity TvVardagsrum => new MediaPlayerEntity(_app, new string[]{"media_player.tv_vardagsrum"});
        public MediaPlayerEntity E32pfs640212 => new MediaPlayerEntity(_app, new string[]{"media_player.32pfs6402_12"});
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonRxApp _app;
        public SwitchEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SwitchEntity NetdaemonWelcomeHome => new SwitchEntity(_app, new string[]{"switch.netdaemon_welcome_home"});
        public SwitchEntity VardagsrumFonsterTv => new SwitchEntity(_app, new string[]{"switch.vardagsrum_fonster_tv"});
        public SwitchEntity NetdaemonLightManager => new SwitchEntity(_app, new string[]{"switch.netdaemon_light_manager"});
        public SwitchEntity NetdaemonHouseStateManager => new SwitchEntity(_app, new string[]{"switch.netdaemon_house_state_manager"});
        public SwitchEntity HallLampa => new SwitchEntity(_app, new string[]{"switch.hall_lampa"});
        public SwitchEntity NetdaemonTv => new SwitchEntity(_app, new string[]{"switch.netdaemon_tv"});
        public SwitchEntity KokKruka => new SwitchEntity(_app, new string[]{"switch.kok_kruka"});
    }

    public partial class WeatherEntities
    {
        private readonly NetDaemonRxApp _app;
        public WeatherEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public WeatherEntity Hem => new WeatherEntity(_app, new string[]{"weather.hem"});
    }

    public partial class BinarySensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public BinarySensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public BinarySensorEntity HallPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.hall_pir"});
        public BinarySensorEntity Updater => new BinarySensorEntity(_app, new string[]{"binary_sensor.updater"});
    }

    public partial class InputSelectEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputSelectEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputSelectEntity HouseModeSelect => new InputSelectEntity(_app, new string[]{"input_select.house_mode_select"});
    }

    public partial class LightEntities
    {
        private readonly NetDaemonRxApp _app;
        public LightEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LightEntity Testlampa => new LightEntity(_app, new string[]{"light.testlampa"});
        public LightEntity HallTak1 => new LightEntity(_app, new string[]{"light.hall_tak1"});
        public LightEntity HallTak2 => new LightEntity(_app, new string[]{"light.hall_tak2"});
        public LightEntity ConfigurationTool1 => new LightEntity(_app, new string[]{"light.configuration_tool_1"});
        public LightEntity VardagsrumFonster => new LightEntity(_app, new string[]{"light.vardagsrum_fonster"});
    }

    public partial class PersistentNotificationEntities
    {
        private readonly NetDaemonRxApp _app;
        public PersistentNotificationEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PersistentNotificationEntity ConfigEntryDiscovery => new PersistentNotificationEntity(_app, new string[]{"persistent_notification.config_entry_discovery"});
    }

    public partial class SensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public SensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SensorEntity Consumption5 => new SensorEntity(_app, new string[]{"sensor.consumption_5"});
        public SensorEntity Consumption3 => new SensorEntity(_app, new string[]{"sensor.consumption_3"});
        public SensorEntity Power4 => new SensorEntity(_app, new string[]{"sensor.power_4"});
        public SensorEntity Hacs => new SensorEntity(_app, new string[]{"sensor.hacs"});
        public SensorEntity HallPirBatteryLevel => new SensorEntity(_app, new string[]{"sensor.hall_pir_battery_level"});
        public SensorEntity Power6 => new SensorEntity(_app, new string[]{"sensor.power_6"});
    }

    public partial class NetdaemonEntities
    {
        private readonly NetDaemonRxApp _app;
        public NetdaemonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public NetdaemonEntity Status => new NetdaemonEntity(_app, new string[]{"netdaemon.status"});
    }

    public partial class SunEntities
    {
        private readonly NetDaemonRxApp _app;
        public SunEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SunEntity Sun => new SunEntity(_app, new string[]{"sun.sun"});
    }

    public partial class PersonEntities
    {
        private readonly NetDaemonRxApp _app;
        public PersonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PersonEntity MagnusAhling => new PersonEntity(_app, new string[]{"person.magnus_ahling"});
    }

    public partial class ZoneEntities
    {
        private readonly NetDaemonRxApp _app;
        public ZoneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ZoneEntity Home => new ZoneEntity(_app, new string[]{"zone.home"});
    }
}