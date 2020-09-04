using System;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace Vikingen.Home.Automations
{
    /// <summary>
    ///     Greets Lotta when she gets home
    /// </summary>
    public class WelcomeHomeApp : NetDaemonRxApp
    {
        public override void Initialize()
        {
            //stangtestlampa();
            Entity("binary_sensor.hall_pir").StateChanges
                .Where(e => e.New?.State == "on" && e.Old?.State == "off")
                .Subscribe(
                    e =>
                    {

                        //ToDo: Tracker och välkommen hem automation.... 
                        //Entity("light.hall_tak1").TurnOn();
                        //Entity("light.hall_tak2").TurnOn();
                        //this.Tts("media_player.vardagsrum", "Hej hopp");
                        //Entity("light.testlampa").TurnOn();
                    }
                );

            /* Entity("binary_sensor.hall_pir").StateChanges
                .Where(e => e.Old?.State == "on" && e.New?.State == "off")
                .NDSameStateFor(TimeSpan.FromMinutes(1))
                .Subscribe(
                    e =>
                    {

                        //Entity("light.hall_tak1").TurnOff();
                        //Entity("light.hall_tak2").TurnOff();
                        //Entity("light.testlampa").TurnOff();
                    }
                ); */
        }
        /* private void stangtestlampa()
        {
            Entity("light.testlampa").TurnOn();
        } */
    }
}
