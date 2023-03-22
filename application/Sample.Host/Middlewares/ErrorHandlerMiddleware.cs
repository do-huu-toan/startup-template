using Microsoft.AspNetCore.Http;
using Sample.Host.ViewModels.Response;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sample.Host.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception e)
            {
                var response = context.Response;
                switch (e)
                {
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var result = JsonSerializer.Serialize(new ResponseApi()
                {
                    message = e?.Message,
                    data = null,
                    isSuccess = false
                });
                await response.WriteAsync(result);
            }
        }
    }
}
