using System.Collections.Generic;

namespace MasterBlog.Application.Contracts.ArticelCategory
{
    public interface IArticelCategoryApplication
    {
        List<ArticelCategoryViewModel> GetAll1();
        void Create(CreateArticelCategory command);
        void Edit(RenameArticelCategory command);
        RenameArticelCategory GetBy(long id);
        void Delete(long id);
        void Active(long id);
    }
}
