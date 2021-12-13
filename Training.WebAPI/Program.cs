using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Training.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
              .ConfigureWebHostDefaults(webBuilder =>
              {
                  webBuilder.UseStartup<Startup>();
              })
              .Build()
              .Run();
        }

    }
}