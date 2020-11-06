using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TestAppConfig
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
               webBuilder.ConfigureAppConfiguration(config =>
               {
                   var settings = config.Build();
                   var connection = "Endpoint=https://windwsvisford.azconfig.io;Id=WfY2-l4-s0:EpxGKG/6o2dh2Rj8nPKR;Secret=N0DPO3kM3WJBbxHoICU3/rK8byvJn7oMItOOLMt3Dl0=";
                   config.AddAzureAppConfiguration(connection);
               }).UseStartup<Startup>());
    }
}
