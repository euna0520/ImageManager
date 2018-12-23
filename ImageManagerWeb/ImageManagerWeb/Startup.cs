using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ImageManagerWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                // 응답할 콘텐트의 형식과 캐릭터셋을 지정
                context.Response.Headers.Add("Content-Type", "text/html; charset=UTF-8");
                // 현재 HTTP컨텍스트에 지정한 텍스트 내용을 써서 응답
                await context.Response.WriteAsync(@"<html>
    <head>
        <title>연습1</title>
        
        <link rel=""stylesheet"" href=""master.css"">
    </head>
    <body>
        <form>
            <p>A Image: <input type=""text""></p>
            <p>B Image: <input type=""text""></p>
            <p>C Image: <input type=""text""></p>
            <p>D Image: <input type=""text""></p>
            <p><input type=""button"" value=""Preview""></p>
            <p><input type=""submit"" value=""Save""></p>
        </form>
    </body>
</html>");
            });
        }
    }
}
