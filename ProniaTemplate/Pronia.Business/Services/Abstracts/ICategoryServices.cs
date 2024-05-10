using Pronia.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Business.Services.Abstracts
{
    public interface ICategoryServices
    {
        void AddCategory(Category newCategory);
        void DeleteCategory(int id);
        void UpdateCategory(int id,Category newCategory);

        Category GetCategory(Func<Category,bool>? func=null);
        List<Category> GetAllCategory(Func<Category, bool>? func = null);
    }
}
