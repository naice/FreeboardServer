using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;
using System.Threading.Tasks;
using Devkoes.Restup.WebServer.Http;
using Devkoes.Restup.WebServer.Rest;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace FreeboardServer
{
    public sealed class StartupTask : IBackgroundTask
    {
        BackgroundTaskDeferral deferral;
        HttpServer server;
        RestRouteHandler restRouteHandler;

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            deferral = taskInstance.GetDeferral();

            restRouteHandler = new RestRouteHandler();
            restRouteHandler.RegisterController<Controller.TestController>();


            server = new HttpServer(8090);
            server.RegisterRoute(restRouteHandler);
            server.StartServerAsync()
                .ContinueWith(_ => deferral.Complete());
        }
    }
}
