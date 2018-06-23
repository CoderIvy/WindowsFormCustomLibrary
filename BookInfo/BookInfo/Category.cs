using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfo
{
    class Category
    {
        protected int categoryID;
        protected string categoryName;

        public Category(int newCategoryID, string newCategoryName)
        {
            this.categoryID = newCategoryID;
            this.categoryName = newCategoryName;
        }

        public int getCategoryID()
        {
            return this.categoryID;
        }

        public void setCategoryID(int newID)
        {
            this.categoryID = newID;
        }

        public string getCategoryName()
        {
            return this.categoryName;
        }

        public void setCategoryName(string newName)
        {
            this.categoryName = newName;
        }
    }
}
