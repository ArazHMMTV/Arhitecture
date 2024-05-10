using Pronia.Business.Exceptions;
using Pronia.Business.Services.Abstracts;
using Pronia.Core.Models;
using Pronia.Core.RepositoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Business.Services.Concretes
{
    public class CategoryService : ICategoryServices
    {
        public ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void AddCategory(Category newCategory)
        {
            if (!_categoryRepository.GetALl().Any(x => x.Name == newCategory.Name))
                _categoryRepository.Add(newCategory);
            else
                throw new DublicateCategory("Category eyni ola bilmez!");
            _categoryRepository.Commit();
        }


        public void DeleteCategory(int id)
        {
            Category existCategory = _categoryRepository.Get(x=>x.Id==id);
            if (existCategory != null) throw new NullReferenceException("Category yoxdur");
            _categoryRepository.Delete(existCategory);
            _categoryRepository.Commit();   
        }

        public List<Category> GetAllCategory(Func<Category, bool>? func = null)
        {
            return _categoryRepository.GetALl(func);
        }

        public Category GetCategory(Func<Category, bool>? func = null)
        {
            return _categoryRepository.Get(func);
        }

        public void UpdateCategory(int id, Category newCategory)
        {
            Category oldCategory = _categoryRepository.Get(x=> x.Id==id);
            if (oldCategory != null) throw new NullReferenceException("Bele Category yoxdur");

            if (!_categoryRepository.GetALl().Any(x => x.Name == newCategory.Name))
            {
                oldCategory.Name= newCategory.Name;
                _categoryRepository.Commit(); 
            }
                
            else 
                throw new DublicateCategory("Category eyni ola bilmez!");

        }
    }
}
