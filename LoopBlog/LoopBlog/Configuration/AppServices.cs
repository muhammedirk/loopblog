using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using LoopBlog.Authorization;
using LoopBlog.BusinessManagers;
using LoopBlog.BusinessManagers.Interfaces;
using LoopBlog.Data;
using LoopBlog.Data.Models;
using LoopBlog.Service;
using LoopBlog.Service.Interfaces;
using System.IO;

namespace LoopBlog.Configuration {
    public static class AppServices {
        public static void AddDefaultServices(this IServiceCollection serviceCollection, IConfiguration Configuration) {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            // varsayılan kimlik bilgisini bizim kullanıcımızdan alması için application user kullanıldı
            serviceCollection.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                //doğrulanmış hesap gerekliliğini kaldırdım ama site içinde kendi tekrar doğrulama yapmadan açmadığını farkettim için e mail olmadan doğrudan link ile doğrulama yapılabiliyor . yeni bir kayıt açınca doğrulamayı otomatik yapıyor


                .AddEntityFrameworkStores<ApplicationDbContext>();
            serviceCollection.AddControllersWithViews().AddRazorRuntimeCompilation();
            serviceCollection.AddRazorPages();

            serviceCollection.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
        }

        public static void AddCustomServices(this IServiceCollection serviceCollection) {
            serviceCollection.AddScoped<IPostBusinessManager, PostBusinessManager>();
            serviceCollection.AddScoped<IAdminBusinessManager, AdminBusinessManager>();
            serviceCollection.AddScoped<IHomeBusinessManager, HomeBusinessManager>();

            serviceCollection.AddScoped<IPostService, PostService>();
            serviceCollection.AddScoped<IUserService, UserService>();
        }

        public static void AddCustomAuthorization(this IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IAuthorizationHandler, PostAuthorizationHandler>();
        }
    }
}