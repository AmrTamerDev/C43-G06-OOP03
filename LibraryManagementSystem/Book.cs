using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        #region Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        #endregion

        #region Constructor
        public Book(string _Title, string _Author, string _ISBN)
        {
            Title = _Title;
            Author = _Author;
            ISBN = _ISBN;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Information Of Book\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}";
        }
        #endregion
    }
}
