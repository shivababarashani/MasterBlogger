using MasterBlog.Application.Contracts.ArticelCategory;
using MasterBlog.Domain.ArticelCategoryAgg;
using MasterBlog.Domain.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MasterBlog.Application
{
    public class ArticelCategoryApplication : IArticelCategoryApplication
    {
        private readonly IArticelCategoryRepository _articelCategoryRepository;
        private readonly IArticelCategoryValidatorService _articelCategoryValidatorService;
        public ArticelCategoryApplication(IArticelCategoryRepository articelCategoryRepository)
        {
            _articelCategoryRepository = articelCategoryRepository;
        }

        public void Active(long id)
        {
            var articelcategory = _articelCategoryRepository.GetBy(id);
            articelcategory.Activate();
            _articelCategoryRepository.Save();
        }

        public void Create(CreateArticelCategory command)
        {
            var articelCategory = new ArticelCategory(command.Title, _articelCategoryValidatorService);
            _articelCategoryRepository.Add(articelCategory);
        }

        public void Delete(long id)
        {
            var articelcategory = _articelCategoryRepository.GetBy(id);
            articelcategory.Remove();
            _articelCategoryRepository.Save();
        }

        public void Edit(RenameArticelCategory command)
        {
            var articel = _articelCategoryRepository.GetBy(command.Id);
            articel.Rename(command.Title);
            _articelCategoryRepository.Save();
        }

        public List<ArticelCategoryViewModel> GetAll1()
        {
            var articelCategories = _articelCategoryRepository.GetAll();
            var result = new List<ArticelCategoryViewModel>();
            foreach (var item in articelCategories)
            {
                result.Add(
                    new ArticelCategoryViewModel
                    {
                        Id = item.Id,
                        Titel = item.Titel,
                        IsDeleted = item.IsDeleted,
                        CreationDate = item.CreationDate.ToString(CultureInfo.InvariantCulture)
                    });
            }
            return result;
        }

        public RenameArticelCategory GetBy(long id)
        {
           var articelcategory= _articelCategoryRepository.GetBy(id);
            RenameArticelCategory renameArticel = new RenameArticelCategory
            {
                Id = articelcategory.Id,
                Title = articelcategory.Titel
            };
            return renameArticel;

        }
    }
}
