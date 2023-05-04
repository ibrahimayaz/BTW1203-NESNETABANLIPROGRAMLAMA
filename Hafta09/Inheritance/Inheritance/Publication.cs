using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Publication
    {
        public string title;
        public double price;
        public int copies;

        public Publication(string title, double price, int copies)
        {
            this.title = title;
            this.price = price;
            this.copies = copies;
        }

        public string SellCopy()
        {
            return title;
        }
    }
}
