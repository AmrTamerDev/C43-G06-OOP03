using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class PrintedBook : Book
    {
        #region Attribute
        public int pageCount;
        #endregion

        #region Constructor
        public PrintedBook(string Title, string Author, string ISBN, int PageCount) : base(Title, Author, ISBN)
        {
            pageCount = PageCount;
        }
        #endregion

        #region Property
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (value >= 0)
                    pageCount = value;
                else
                    pageCount = 0;
            }
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return base.ToString() + $"\nPage Count: {pageCount}";
        }
        #endregion
    }
}
