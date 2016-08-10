
using Devkoes.Restup.WebServer.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeboardServer.Controller
{
    internal class Response
    {
        public DateTime DateTimeNow { get; set; }
        public int Calls { get; set; }

        internal GetResponse GetAsResponse()
        {
            return new GetResponse(GetResponse.ResponseStatus.OK, Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }
    }
}
