using MasterBlog.Application;
using MasterBlog.Application.Contracts.ArticelCategory;
using MasterBlog.Domain.ArticelCategoryAgg;
using MasterBlogger.Infrastructure.EfCore;
using MasterBlogger.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterBlogger.Infrastructure.Config
{
   public class Bootstrapper
    {
        public static void Config(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IArticelCategoryApplication, ArticelCategoryApplication>();
            services.AddTransient<IArticelCategoryRepository, ArticelCategoryRepository>();
            services.AddDbContext<MasterBloggerContext>(options => options.UseSqlServer(connectionString));

        }
    }
}
