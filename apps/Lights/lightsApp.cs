using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using Netdaemon.Generated.Reactive;


namespace Vikingen.Home.Automations
{
    /// <summary>
    ///     Manage default lights and implements the following use-cases:
    ///         - Flowerlamps turn on and off depending on housestate (Dag och Natt)
    ///         - Turns on nightlight in hallway when movement, turns off in 5 minutes
    ///         - Manage kitchen lights
    ///         - Manage Livingroom lights
    ///         - Manage Office lights
    ///         - Manage InBetweenrom lights
    /// </summary>
    public class LightManager : GeneratedAppBase
    {
        #region -- Config properties --
        public bool NightTime = false;
        public string? HallPir { get; set; }

        #endregion

        /// <summary>
        ///     Initialize, is automatically run by the daemon
        /// </summary>
        public override void Initialize()
        {
            ManageTimeOfDayScenes();
            ManageNightLights();

            //TurnOffFlowerLamps();
            //TurnOnFlowerLamps();
            //ManageNightlightHallway();
            //ManageLightsVardagsrum();
            //ManageLightsKok();
            //ManageLightsMellanrum();
            //ManageLightsKontor();
            //ManageWindowLightsOn();
            //ManageWindowLightsOff();
            //Testlight();

        }

        // <summary>
        ///     Returns true if it is currently night
        /// </summary>
        public bool IsNight => InputSelect.HouseModeSelect?.State == "Natt";
        public bool IsEvening => InputSelect.HouseModeSelect?.State == "Kväll";
        public bool IsMorning => InputSelect.HouseModeSelect?.State == "Morgon";


        private void ManageTimeOfDayScenes()
        {
            Entity("input_select.house_mode_select")
                .StateChanges
                .Where(e => e.New.State == "Dag")
                .Subscribe(s => TurnOffAmbient());

            Entity("input_select.house_mode_select")
                .StateChanges
                .Where(e => e.New.State == "Kväll")
                .Subscribe(s => TurnOnAmbient());

            Entity("input_select.house_mode_select")
                .StateChanges
                .Where(e => e.New.State == "Natt")
                .Subscribe(s => TurnOffAmbient());

            Entity("input_select.house_mode_select")
                .StateChanges
                .Where(e => e.New.State == "Morgon")
                .Subscribe(s => TurnOnAmbient());

            Entity("input_select.house_mode_select")
                .StateChanges
                .Where(e => e.New.State == "Städning")
                .Subscribe(s => RunScript("cleaning_scene"));
        }


        private void TurnOffAmbient()
        {
            Entity("switch.vardagsrum_fonster_tv").TurnOff();
            Thread.Sleep(100);
            Entity("light.vardagsrum_fonster").TurnOff(new { transition = 0 });
            Thread.Sleep(100);
            Entity("switch.kok_fonsterlampor").TurnOff();
            Thread.Sleep(100);
            Entity("light.mellanrummet_fonster").TurnOff(new { transition = 0 });
            Thread.Sleep(100);
            Entity("light.kontoret_fonster").TurnOff(new { transition = 0 });
            Thread.Sleep(100);
        }

        private void TurnOnAmbient()
        {
            Entity("switch.vardagsrum_fonster_tv").TurnOn();
            Thread.Sleep(100);
            Entity("light.vardagsrum_fonster").TurnOn(new { transition = 0 });
            Thread.Sleep(100);
            Entity("switch.kok_fonsterlampor").TurnOn();
            Thread.Sleep(100);
            Entity("light.mellanrummet_fonster").TurnOn(new { transition = 0 });
            Thread.Sleep(100);
            Entity("light.kontoret_fonster").TurnOn(new { transition = 0 });
            Thread.Sleep(100);
        }
        private void ManageNightLights()
        {
            Entity(HallPir!)
            .StateChanges
            .Where(e =>
                e.New?.State == "on" &&
                e.Old?.State == "off" &&
                (IsNight || IsMorning || IsEvening))
            .Subscribe(
                s =>
                {
                    Light.HallTak1.TurnOn(new { transition = 0 });
                    Light.HallTak2.TurnOn(new { transition = 0 });

                }
            );

            Entity(HallPir!)
                 .StateChanges
                 .Where(e =>
                     e.New?.State == "off" &&
                     e.Old?.State == "on" &&
                     (IsNight || IsMorning || IsEvening) &&
                     !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
                 .NDSameStateFor(TimeSpan.FromMinutes(1))
                 .Subscribe(
                     s =>
                     {
                         Light.HallTak1.TurnOff(new { transition = 0 });
                         Light.HallTak2.TurnOff(new { transition = 0 });
                     }
                 );

        }
        // Todo, make this part of Fluent API
        private bool IsTimeNowBetween(TimeSpan fromSpan, TimeSpan toSpan)
        {
            var now = DateTime.Now.TimeOfDay;
            if (now >= fromSpan && now <= toSpan)
                return true;

            return false;
        }

        private void Testlight()
        {
            //Entity("switch.vardagsrum_fonster_tv").TurnOff();
            //Entity("light.testlampa").TurnOff();
            //Entity("light.vardagsrum_fonster").TurnOn();
            //Entity("switch.kok_fonsterlampor").TurnOff();
            //Entity("light.mellanrummet_fonster").TurnOff();
            //Entity("light.mellanrummet_tak").TurnOff();
            //Entity("light.kontoret_tak").TurnOff();
            //Entity("light.kontoret_fonster").TurnOff();
        }



        // Old code --> Keeping it 4 a little while until my new config is confimd to be stable
        // private void ManageWindowLightsOn()
        // {

        //     Entity("sensor.outdoor_light").StateChanges
        //     .Where(e => e.New?.State is double && e.New.State < 100.0 || e.New?.State is long && e.New.State < 100)
        //     .Subscribe(
        //         e =>
        //         {
        //             Entity("light.kontoret_fonster").TurnOn();
        //             Entity("light.mellanrummet_fonster").TurnOn();
        //             Entity("switch.kok_fonsterlampor").TurnOn();
        //             Entity("switch.vardagsrum_fonster_tv").TurnOn();
        //             Entity("light.vardagsrum_fonster").TurnOn();
        //         }
        //     );
        // }
        // private void ManageWindowLightsOff()
        // {

        //     Entity("sensor.outdoor_light").StateChanges
        //     .Where(e => e.New?.State is double && e.New.State > 100.0 || e.New?.State is long && e.New.State > 100)
        //     .Subscribe(
        //          e =>
        //         {

        //             Entity("light.kontoret_fonster").TurnOff();
        //             Entity("light.mellanrummet_fonster").TurnOff();
        //             Entity("switch.kok_fonsterlampor").TurnOff();
        //             Entity("switch.vardagsrum_fonster_tv").TurnOff();
        //             Entity("light.vardagsrum_fonster").TurnOff();
        //         }
        //      );

        // }


        // private void ManageNightlightHallway()
        // {
        //     Entity(HallPir!).StateChanges
        //             .Where(e => e.New?.State == "on" && e.Old?.State == "off" && NightTime)
        //             .Subscribe(
        //                 e =>
        //                 {

        //                     Entity("light.hall_tak1").TurnOn();
        //                     Entity("light.hall_tak2").TurnOn();
        //                     Log($"Turn On NightLights {DateTime.Now}");
        //                 }
        //             );

        //     Entity(HallPir!).StateChanges
        //         .Where(e => e.Old?.State == "on" && e.New?.State == "off" && NightTime)
        //         .NDSameStateFor(TimeSpan.FromMinutes(5))
        //         .Subscribe(
        //             e =>
        //             {
        //                 Entity("light.hall_tak1").TurnOff();
        //                 Entity("light.hall_tak2").TurnOff();
        //                 Log($"Turn Off NightLights {DateTime.Now}");
        //             }
        //         );
        // }

        // private void TurnOffFlowerLamps()
        // {
        //     Entity("input_select.house_mode_select")
        //         .StateChanges
        //         .Where(e => e.New.State == "Natt")
        //         .Subscribe(s =>
        //         {
        //             Entity("switch.hall_lampa").TurnOff();
        //             NightTime = true;
        //         });
        //     Log($"Turn Off Flowerlights {DateTime.Now}");
        // }

        // private void TurnOnFlowerLamps()
        // {
        //     Entity("input_select.house_mode_select")
        //         .StateChanges
        //         .Where(e => e.New.State == "Dag")
        //         .Subscribe(s =>
        //         {
        //             Entity("switch.hall_lampa").TurnOn();
        //             Entity("switch.kok_kruka").TurnOn();
        //             NightTime = false;
        //         });
        //     Log($"Turn Off Flowerlights {DateTime.Now}");

        // }


        //  private void ManageLightsKontor()
        // {
        //     RunDaily("17:59:00", () => Entity("light.kontoret_fonster").TurnOn());
        //     RunDaily("23:59:00", () => Entity("light.kontoret_fonsterr").TurnOff());

        // }
        // private void ManageLightsMellanrum()
        // {
        //     RunDaily("18:00:00", () => Entity("light.mellanrummet_fonster").TurnOn());
        //     RunDaily("23:59:30", () => Entity("light.mellanrummet_fonster").TurnOff());
        //     Log($"Turn On/Off Lights Kitchen {DateTime.Now}");
        // }

        // private void ManageLightsKok()
        // {
        //     RunDaily("18:00:30", () => Entity("switch.kok_fonsterlampor").TurnOn());
        //     RunDaily("23:59:45", () => Entity("switch.kok_fonsterlampor").TurnOff());
        //     Log($"Turn On/Off Lights Kitchen {DateTime.Now}");
        // }
        // private void ManageLightsVardagsrum()
        // {
        //     RunDaily("18:00:45", () => Entity("switch.vardagsrum_fonster_tv").TurnOn());
        //     RunDaily("23:59:55", () => Entity("switch.vardagsrum_fonster_tv").TurnOff());
        //     RunDaily("18:00:50", () => Entity("light.vardagsrum_fonster").TurnOn());
        //     RunDaily("23:59:57", () => Entity("light.vardagsrum_fonster").TurnOff());
        //     Log($"Turn On/Off Lights vardagsrum {DateTime.Now}");
        // }
    }
}