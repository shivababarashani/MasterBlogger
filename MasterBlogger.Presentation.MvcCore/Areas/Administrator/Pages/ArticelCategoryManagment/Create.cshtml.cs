using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterBlog.Application.Contracts.ArticelCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MasterBlogger.Presentation.MvcCore.Areas.Administrator.Pages.ArticelCategoryManagment
{
    public class CreateModel : PageModel
    {
        private IArticelCategoryApplication _articelCategoryApplication;

        public CreateModel(IArticelCategoryApplication articelCategoryApplication)
        {
            _articelCategoryApplication = articelCategoryApplication;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateArticelCategory command)
        {
            _articelCategoryApplication.Create(command);
            return RedirectToPage("./List");

        }
    }
}
