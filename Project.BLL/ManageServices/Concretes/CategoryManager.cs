using Project.BLL.ManageServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManageServices.Concretes
{
    public class CategoryManager: BaseManager<Category>, ICategoryManager
    {
        ICategoryRepository _cRep;
        public CategoryManager(ICategoryRepository crep): base(crep)
        {
            _cRep = crep;
        }

        public override string Add(Category item)
        {
            if (item.CategoryName != null)
            {
                _cRep.Add(item);

                _cRep.SpecialCategoryCreation();
                return "Kategori eklendi";
            }

            return "Kategori ismi girilmemiş";
        }

        public void BaskaMetot()
        {
            throw new NotImplementedException();
        }

        public void SpecialCategoryCreation()
        {
            throw new NotImplementedException();
        }
    }
}
