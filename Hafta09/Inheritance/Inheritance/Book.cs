using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Book:Publication
    {
        public string author;

        public Book(string title, double price, int copies) : base(title, price, copies)
        {
        }



        

        public string OrderCopies()
        {
            return author;
        }
    }
}
