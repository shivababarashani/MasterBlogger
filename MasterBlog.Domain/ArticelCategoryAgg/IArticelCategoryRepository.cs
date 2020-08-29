using System;
using System.Collections.Generic;
using System.Text;

namespace MasterBlog.Domain.ArticelCategoryAgg
{
    public interface IArticelCategoryRepository
    {
        List<ArticelCategory> GetAll();
        ArticelCategory GetBy(long id);
        void Add(ArticelCategory entity);
        void Save();
        bool IsExist(string title);

    }
}
