using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace aXe.WebhostHandler
{
    public class WebHost
    {
        private static WebHost host = new WebHost();
        public static WebHost GetInstance()
        {
            return host;
        }

        public Task HandleRequest(HttpContext c)
        {
            c.Response.WriteAsync("hello world");
            return 
        }
    }
}
