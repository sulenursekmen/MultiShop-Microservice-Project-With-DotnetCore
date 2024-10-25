namespace MultiShop.WebUI.Middleware
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var isLoggedIn = context.Session.GetString("IsLoggedIn");

            if (isLoggedIn != "true" && !context.Request.Path.Value.Contains("Login"))
            {
                context.Response.Redirect("/Login/Index");
                return;
            }

            await _next(context);
        }
    }
}
