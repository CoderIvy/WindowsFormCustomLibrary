using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfo
{
    class Book
    {
        protected int ID;
        protected string category;
        protected string author;
        protected string name;
        protected float price;

        public Book(int newId, string newCategory, string newAuthor, string newName, float newPrice)
        {
            this.ID = newId;
            this.category = newCategory;
            this.author = newAuthor;
            this.name = newName;
            this.price = newPrice;

        }

        public int getID()
        {
            return this.ID;
        }
        public void setID(int newID)
        {
            this.ID = newID;
        }

        public string getCategory()
        {
            return this.category;
        }

        public void setCategoryID(string newCategoryID)
        {
            this.category = newCategoryID;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public void setAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }
        public string getName()
        {
            return this.name;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public float getPrice()
        {
            return this.price;
        }

        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }
    }
}
