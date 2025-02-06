using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class EBook : Book
    {
        #region Attribute
        public int fileSize; 
        #endregion

        #region Constructor
        public EBook(string Title, string Author, string ISBN, int FileSize) : base(Title, Author, ISBN)
        {
            fileSize = FileSize;
        } 
        #endregion

        #region Property
        public int FileSize
        {
            get { return fileSize; }
            set
            {
                if (value >= 0)
                    fileSize = value;
                else
                    fileSize = 0;
            }
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return base.ToString() + $"\nFile Size: {FileSize}";
        }
        #endregion

    }
}
