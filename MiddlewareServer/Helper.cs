using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareServer
{
	public static class Helper
	{
		public static string GetContentType(string path)
		{
			if (Path.GetExtension(path) == ".html") return "text/html";
			if (Path.GetExtension(path) == ".css") return "text/css";
			if (Path.GetExtension(path) == ".js") return "application/javascript";
			return "application/octet-stream";
		}


	}
}
