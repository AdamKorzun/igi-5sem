using System;
using Microsoft.AspNetCore.Builder;
using WEB_953505_KORZUN.Middleware;

namespace WEB_953505_KORZUN.Extensions
{
    public static class appExtensions
    {
        public static IApplicationBuilder UseFileLogging(this
                    IApplicationBuilder app)
                    => app.UseMiddleware<LogMiddleware>();
    }
}
