using MasterBlog.Domain.Services;
using System;

namespace MasterBlog.Domain.ArticelCategoryAgg
{
    public class ArticelCategory
    {
        public long Id { get;private set; }
        public string Titel { get;private set; }
        public bool IsDeleted { get;private set; }
        public DateTime CreationDate { get;private set; }

        public ArticelCategory(string titel,IArticelCategoryValidatorService articelCategoryValidatorService)
        {
            NullTitel(titel);
            articelCategoryValidatorService.ChackDuplicateRecord(titel);
              Titel = titel;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }
        public void NullTitel(string titel)
        {
            if (string.IsNullOrWhiteSpace(titel))
                throw new ArgumentNullException();
        }
        public void Rename(string title)
        {
            NullTitel(title);
            Titel = title;
        }
        public void Remove()
        {
            IsDeleted = true;
        }
        public void Activate()
        {
            IsDeleted = false;
        }
    }
    
    
}
