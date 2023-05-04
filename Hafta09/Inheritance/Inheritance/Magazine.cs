using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Magazine : Publication
    {
      
        public Magazine(string title, double price, int copies) : base(title, price, copies)
        {
        }
        public int orderQty;
        public string currIssue;

        public string AdjustQty()
        {
        return currIssue;
        }

        public string RecNewIssue(string newIssue)
        {
            return newIssue;
        }




    }
}
