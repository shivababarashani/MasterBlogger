using System;
using System.Collections.Generic;
using System.Text;

namespace MasterBlog.Application.Contracts.ArticelCategory
{
    public class ArticelCategoryViewModel
    {
        public long Id { get; set; }
        public string Titel { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }


    }
}
