using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfo
{
    class Author
    {
        protected string authorName;
        protected int authorID;

        public Author(int newAuthorID, string newAuthorName)
        {
            this.authorID = newAuthorID;
            this.authorName = newAuthorName;
        }

        public string getAuthorName()
        {
            return this.authorName;
        }

        public void setAuthorName(string newName)
        {
            this.authorName = newName;
        }

        public int getAuthorID()
        {
            return this.authorID;
        }

        public void setAuthorID(int newID)
        {
            this.authorID = newID;
        }
    }
}
