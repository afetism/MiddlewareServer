using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareServer.Middlewares;
public delegate void HttpHandler(HttpListenerContext context);


internal interface IMiddleware
{
	HttpHandler? Next {  get; set; }

	void Handler(HttpListenerContext context);
}
