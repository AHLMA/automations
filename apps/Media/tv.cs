using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using NetDaemon.Common;
using System.Threading;
// <summary>
///     Manage the media in the tv room
/// </summary>
/// <remarks>
///     Following use-cases are implemented
///         - Simple manage tv on off
///
namespace Vikingen.Home.Automations
{
    public class TVmanager : NetDaemonRxApp
    {
        public override void Initialize()
        {
            //TurnOffTV();
            //TurnOnTV();

        }
        private void TurnOffTV()
        {
            Entity("media_player.tv_vardagsrum").TurnOff();
        }
        private void TurnOnTV()
        {
            Entity("media_player.tv_vardagsrum").TurnOn();
        }
    }
}