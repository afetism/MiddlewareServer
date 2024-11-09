using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareServer.Middlewares
{
	public class LoggerMiddleware : Middleware
	{
		public override void Handler(HttpListenerContext context)
		{
            Console.WriteLine("Request Logglandi");
            Console.WriteLine($"{context.Request.Url}");
            Next?.Invoke(context);
            Console.WriteLine("Respond Logglandi");
        }
	}
}
