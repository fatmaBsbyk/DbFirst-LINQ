
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DBFirstProje.Web.Models
{
    public class CategoryRepository
    {
        private static List<Category> _categories;

        //tüm kategorileri getir
        public List<Category> GetAll() 
        {
            return _categories;
        }
        //kategori ekleme
        public List<Category> Categories() => _categories;
        public void Add(Category category)
        {
            _categories.Add(category);
        }
        //kategori silme
        public void Remove(int id)
        {
            var hasCategory = _categories.FirstOrDefault(c => c.Id == id);
            if (hasCategory == null)
            {
                throw new Exception($"{id} nolu id ye sahip kategori bulunmamaktadır.");
            } 
            _categories.Remove(hasCategory);
        }
        //kategori güncelleme
        public void Update(Category category)
        {
            var hasCategory = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (hasCategory == null)
            {
                throw new Exception($"{category.Id} nolu id ye sahip kategori bulunmamaktadır.");
            }
            hasCategory.CategoryName = category.CategoryName;
            hasCategory.Description = category.Description;
            var index=_categories.FindIndex(x=>x.Id == category.Id);
            _categories[index]=category;
        }
    }
}


