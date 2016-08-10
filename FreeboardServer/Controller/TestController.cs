using Devkoes.Restup.WebServer.Attributes;
using Devkoes.Restup.WebServer.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeboardServer.Controller
{
    [RestController(InstanceCreationType.Singleton)]
    internal class TestController
    {
        static int calls = 0;

        [UriFormat("/TestController/GetTest")]
        public GetResponse GetTest()
        {
            Response res = new Response();

            res.Calls = calls++;
            res.DateTimeNow = DateTime.Now;

            return res.GetAsResponse();
        }
    }
}
