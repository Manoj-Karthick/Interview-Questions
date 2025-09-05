
namespace WebAPI.Questions.CustomClass
{
    public class CustomException : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                int a = 1;
                
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync($"An error occurred {ex.Message}");
            }
        }
    }
}
