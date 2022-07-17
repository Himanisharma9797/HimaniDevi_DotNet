using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Formatting.Compact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ElearningSystem.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
                 Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Verbose()
                 .WriteTo.Console(new RenderedCompactJsonFormatter())
                 .WriteTo.File("C:\\Users\\himani.devi\\Desktop\\Serilog\\logs.txt", rollingInterval: RollingInterval.Day)
                 .CreateLogger();         
                  CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.UseStartup<Startup>();
                });
    }
}