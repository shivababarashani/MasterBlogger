using MasterBlog.Domain.ArticelCategoryAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterBlog.Domain.Services
{
    public interface IArticelCategoryValidatorService
    {
        void ChackDuplicateRecord(string title);
    }
    public class ArticelCategoryValidatorService : IArticelCategoryValidatorService
    {
        private readonly IArticelCategoryRepository _articelCategoryRepository;

        public ArticelCategoryValidatorService(IArticelCategoryRepository articelCategoryRepository)
        {
            _articelCategoryRepository = articelCategoryRepository;
        }

        public void ChackDuplicateRecord(string title)
        {
            _articelCategoryRepository.IsExist(title);
            throw new ArgumentNullException();
        }
    }
}
