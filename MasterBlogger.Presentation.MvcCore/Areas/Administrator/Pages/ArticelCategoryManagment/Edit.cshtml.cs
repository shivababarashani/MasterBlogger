using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterBlog.Application.Contracts.ArticelCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MasterBlogger.Presentation.MvcCore.Areas.Administrator.Pages.ArticelCategoryManagment
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public RenameArticelCategory ArticelCategory { get; set; }
        private readonly IArticelCategoryApplication _articelCategory;

        public EditModel(IArticelCategoryApplication articelCategory)
        {
            _articelCategory = articelCategory;
        }

        public void OnGet(long id)
        {
            _articelCategory.GetBy(id);
        }
        public RedirectToPageResult OnPost()
        {
            _articelCategory.Edit(ArticelCategory);
            return RedirectToPage("./ List");
        }
    }
}
