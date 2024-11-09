using MiddlewareServer.Middlewares;

var staticMiddle = new StaticFileMiddleware();
staticMiddle.Handler()
