using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfo
{
    class BookInfoControl
    {
        private BookInfoLib theInterface;

        public BookInfoControl(BookInfoLib newInterface) {
            theInterface = newInterface;
        }

    }
}
