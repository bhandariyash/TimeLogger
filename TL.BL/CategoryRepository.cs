using System;
using System.Collections.Generic;
using System.Text;

namespace TL.BL
{
    public class CategoryRepository
    {
        public IEnumerable<Category> RetrieveAllCategories()
        {
            List<Category> categories = new List<Category>();
            //retrieve list of categories into 'categories' variable
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            Category category = new Category("", -1, -1);
            //Check if category exists by the id

            return category;
        }
        public bool SaveCategory(Category category)
        {
            bool success = false;

            if (GetCategoryById(category.CategoryId).CategoryId == -1)
            {
                //Call an Insert Stored Procedure
            }
            else
            {
                //Call an Update Stored Procedure
            }
            return success;
        }
        public bool DeleteCategory(Category category)
        {
            bool success = false;
            if (GetCategoryById(category.CategoryId).CategoryId == -1)
            {
                return true;
            }
            else
            {
                //Call delete Stored Procedure
            }
                return success;
        }
    }
}
