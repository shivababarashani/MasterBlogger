using MasterBlog.Domain.ArticelCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterBlogger.Infrastructure.EfCore.Repositories
{
    
    public class ArticelCategoryRepository : IArticelCategoryRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticelCategoryRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public void Add(ArticelCategory entity)
        {
            _context.ArticelCategories.Add(entity);
            _context.SaveChanges();
        }

        public List<ArticelCategory> GetAll()
        {
            return _context.ArticelCategories.OrderByDescending(P=>P.Id).ToList();
        }

        public ArticelCategory GetBy(long id)
        {
            return _context.ArticelCategories.SingleOrDefault(p => p.Id == id);
        }

        public bool IsExist(string title)
        {
            return _context.ArticelCategories.Any(p => p.Titel == title);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
