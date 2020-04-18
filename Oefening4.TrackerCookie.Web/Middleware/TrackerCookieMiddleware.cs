using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Oefening4.TrackerCookie.Web.Middleware
{
    public class TrackerCookieMiddleware
    {
        private readonly RequestDelegate _next;

        public TrackerCookieMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Cookies["tracker"] == null)
            {
                context.Response.Cookies.Append(
                    "tracker",
                    Guid.NewGuid().ToString());
            }
            else
            {
                Trace.WriteLine($"'tracker' cookie found: {context.Request.Cookies["tracker"]}");
            }

            // Aanroep van de volgende middleware!
            await _next(context);
        }
    }
}
