using MasterBlog.Domain.ArticelCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterBlogger.Infrastructure.EfCore.Mapping
{
    public class ArticelCategoryMapping : IEntityTypeConfiguration<ArticelCategory>
    {
        public void Configure(EntityTypeBuilder<ArticelCategory> builder)
        {
            builder.ToTable("ArticelCategories");
            builder.HasKey(p => p.Id);
        }
    }
    
    
}
