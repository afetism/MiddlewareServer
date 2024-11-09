using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareServer.Middlewares
{
	public class StaticFileMiddleware : Middleware
	{
		public override void Handler(HttpListenerContext context)
		{
			if (Path.HasExtension(context.Request.Url?.AbsolutePath))
			{
				try
				{

					var fileName = context.Request.Url?.AbsolutePath.Substring(1);
					var path = string.Empty;
					if (Path.GetExtension(fileName)!=".html")
					{
						path=$@"C:\\Users\\user\\source\repos\\MiddlewareServer\\MiddlewareServer\\Views\\{fileName}";
					}
					else
					{
						path=$@"C:\\Users\\user\\source\\repos\\MiddlewareServer\\MiddlewareServer\\wwwroot\\{fileName}";
					}
					var bytes = File.ReadAllBytes(path);
					context.Response.OutputStream.Write(bytes, 0, bytes.Length);
					context.Response.ContentType=Helper.GetContentType(path);
					Next?.Invoke(context);
				}
				catch
				{
					var bytes = File.ReadAllBytes($@"C:\\Users\\user\\source\repos\\MiddlewareServer\\MiddlewareServer\\Views\\404.html");
					context.Response.OutputStream.Write(bytes, 0, bytes.Length);
					context.Response.ContentType=Helper.GetContentType("404.html");
					
				}
			}
			else
			{
				var bytes = File.ReadAllBytes($@"C:\\Users\\user\\source\repos\\MiddlewareServer\\MiddlewareServer\\Views\\404.html");
				context.Response.OutputStream.Write(bytes, 0, bytes.Length);
				context.Response.ContentType=Helper.GetContentType("404.html");
				
			}
		}
	}
}
