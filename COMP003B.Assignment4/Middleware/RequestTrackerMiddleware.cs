namespace COMP003B.Assignment4
{
    public class RequestTrackerMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTrackerMiddleware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"[Response] {context.Response.StatusCode}");

        }


    }
}
