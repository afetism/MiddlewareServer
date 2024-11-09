using System.Net;

namespace MiddlewareServer.Middlewares;

public class AuthorizationMiddleware : Middleware
{
	public override void Handler(HttpListenerContext context)
	{
		var username = context.Request.QueryString["username"];
		var password = context.Request.QueryString["password"];
		if(username == "afet" || password == "hakunamatata")
		{
			Next?.Invoke(context);
		}
		else
		{

			var bytes = File.ReadAllBytes($@"C:\\Users\\user\\source\repos\\MiddlewareServer\\MiddlewareServer\\Views\\404.html");
			context.Response.OutputStream.Write(bytes, 0, bytes.Length);
			context.Response.ContentType=Helper.GetContentType("404.html");
		
		}
	}
}
