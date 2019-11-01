using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace DisableStatusCodePages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigureHostBuilder(args).Build().Run();
        }

        public static IHostBuilder ConfigureHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webuilder =>
                {
                    webuilder.UseStartup<Startup>();
                });
    }
}
