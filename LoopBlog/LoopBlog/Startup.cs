using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LoopBlog.Configuration;

namespace LoopBlog {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddDefaultServices(Configuration);//düzenli görünüm için taþýndý (Configuration klasörü)
            services.AddCustomServices();//sonradan eklendi
            services.AddCustomAuthorization();//sonradan eklendi
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.AddDefaultConfiguration(env);
        }
    }
}