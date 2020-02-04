using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace links_app
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Map("/a_l_i_v_e", builder => builder.Run(async h =>
            {
                await h.Response.WriteAsync("Hello World");
            });
            foreach (var route in RouteMaps.Routes)
            {
                app.Map(route.Key, builder => builder.Run(async h =>
                {
                    h.Response.Redirect(route.Value);
                    await h.Response.WriteAsync("");
                }));
            }
            app.Run(async (context) =>
            {
                context.Response.Redirect(RouteMaps.HomePageRoot);
                await context.Response.WriteAsync("");
            });
        }
    }
}
