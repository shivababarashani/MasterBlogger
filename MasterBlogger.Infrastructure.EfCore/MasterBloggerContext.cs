using MasterBlog.Domain.ArticelCategoryAgg;
using MasterBlogger.Infrastructure.EfCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MasterBlogger.Infrastructure.EfCore
{
   public class MasterBloggerContext:DbContext
    {
        public DbSet<ArticelCategory> ArticelCategories { get; set; }
        public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticelCategoryMapping());

            //modelBuilder.ApplyConfiguration(new ArticelCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
