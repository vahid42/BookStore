using BS01.Domain;
using BS02.Application.Contract;
using BS03.Application;
using BS04.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BS05.Infrastructure.Config
{
    public class Bootstrap
    {
        public static void Config(IServiceCollection services, string stringConnection)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookAppliaction, BookAppliaction>();
            services.AddDbContext<BookStoreContext>(option => option.UseSqlServer(stringConnection));
        }
    }
}