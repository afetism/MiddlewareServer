using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareServer.Middlewares
{
	public abstract class Middleware : IMiddleware
	{
		public HttpHandler? Next { get ; set; }

		public abstract void Handler(HttpListenerContext context);
	}
}
