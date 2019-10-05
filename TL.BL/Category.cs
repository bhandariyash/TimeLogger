using System;

namespace TL.BL
{
    public class Category
    {
        public string CategoryName { get; set; }
        public int CategoryId { get; private set; }
        public int AddedByUserId { get; private set; }

        public Category(string name, int categoryId, int addedByUserId)
        {
            CategoryName = name;
            CategoryId = categoryId;
            AddedByUserId = addedByUserId;
        }

        public Category()
        {

        }
    }
}
