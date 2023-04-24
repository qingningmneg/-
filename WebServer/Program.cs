using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://*:18800"); //设置端口号
                    webBuilder.UseShutdownTimeout(TimeSpan.FromMinutes(10)); //关闭程序超时时间
                    //测试地址：http://localhost:18800/swagger/index.html
                    webBuilder.ConfigureKestrel((context, options) =>
                    {
                        //options.ListenAnyIP(18800); //设置端口号
                        options.Limits.MaxRequestBodySize = int.MaxValue;
                        options.Limits.MaxRequestBufferSize = int.MaxValue;
                        options.Limits.MaxRequestLineSize = int.MaxValue;
                        options.Limits.MaxResponseBufferSize = int.MaxValue;
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
