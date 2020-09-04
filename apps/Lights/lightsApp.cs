using System;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;


namespace Vikingen.Home.Automations
{
    /// <summary>
    ///     Manage default lights and implements the following use-cases:
    ///         - Flowerlamps turn on and off depending on housestate (Dag och Natt)
    ///         - Turns on nightlight in hallway when movement, turns off in 15 minutes
    ///      
    /// </summary>
    public class LightManager : NetDaemonRxApp
    {
        #region -- Config properties --
        public bool NightTime = false;
        #endregion

        /// <summary>
        ///     Initialize, is automatically run by the daemon
        /// </summary>
        public override void Initialize()
        {
            TurnOffFlowerLamps();
            TurnOnFlowerLamps();
            ManageNightlightHallway();
            ManageLightsVardagsrum();
            //RunEveryMinute(0, () => Toggletestlight());

        }
        private void ManageLightsVardagsrum()
        {
            RunDaily("18:00:00", () => Entity("switch.vardagsrum_fonster_tv").TurnOn());
            RunDaily("23:00:00", () => Entity("switch.vardagsrum_fonster_tv").TurnOff());
            Log($"Turn On/Off Lights vardagsrum {DateTime.Now}");
        }
        private void ManageNightlightHallway()
        {
            Entity("binary_sensor.hall_pir").StateChanges
                    .Where(e => e.New?.State == "on" && e.Old?.State == "off" && NightTime)
                    .Subscribe(
                        e =>
                        {

                            Entity("light.hall_tak1").TurnOn();
                            Entity("light.hall_tak2").TurnOn();
                            Log($"Turn On NightLights {DateTime.Now}");
                        }
                    );

            Entity("binary_sensor.hall_pir").StateChanges
                .Where(e => e.Old?.State == "on" && e.New?.State == "off")
                .NDSameStateFor(TimeSpan.FromMinutes(10))
                .Subscribe(
                    e =>
                    {
                        Entity("light.hall_tak1").TurnOff();
                        Entity("light.hall_tak2").TurnOff();
                        //Entity("light.testlampa").TurnOff();
                        //this.Tts("media_player.vardagsrum", "Hej");
                        Log($"Turn Off NightLights {DateTime.Now}");
                    }
                );
        }

        private void TurnOffFlowerLamps()
        {
            Entity("input_select.house_mode_select")
                .StateChanges
                .Where(e => e.New.State == "Natt")
                .Subscribe(s =>
                {
                    Entity("switch.hall_lampa").TurnOff();
                    Entity("switch.kok_kruka").TurnOff();
                    NightTime = true;
                });
            Log($"Turn Off Flowerlights {DateTime.Now}");
        }

        private void TurnOnFlowerLamps()
        {
            Entity("input_select.house_mode_select")
                .StateChanges
                .Where(e => e.New.State == "Dag")
                .Subscribe(s =>
                {
                    Entity("switch.hall_lampa").TurnOn();
                    Entity("switch.kok_kruka").TurnOn();
                    NightTime = false;
                });
            Log($"urn Off Flowerlights {DateTime.Now}");

        }

        // Todo, make this part of Fluent API
        private bool IsTimeNowBetween(TimeSpan fromSpan, TimeSpan toSpan)
        {
            var now = DateTime.Now.TimeOfDay;
            if (now >= fromSpan && now <= toSpan)
                return true;

            return false;
        }
    }
}