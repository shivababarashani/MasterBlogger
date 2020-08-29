using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterBlog.Application.Contracts.ArticelCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MasterBlogger.Presentation.MvcCore.Area.Pages.ArticelCategoryManagment
{
    public class ListModel : PageModel
    {
        public List<ArticelCategoryViewModel> articelCategories { get; set; }
        private readonly IArticelCategoryApplication _articelCategoryApplication;

        public ListModel(IArticelCategoryApplication articelCategoryApplication)
        {
            _articelCategoryApplication = articelCategoryApplication;
        }

        public void OnGet()
        {
            articelCategories = _articelCategoryApplication.GetAll1();
        }
    }
}
