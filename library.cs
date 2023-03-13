using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
     class library
{
        public string Title { get; set; }
        public double Address { get; set; }
        public double YearOfOpening { get; set; }

        public library() { }
        public library(string title, double address, double yearofopening)
        {
            Title = title;
            Address = address;
            YearOfOpening = yearofopening;
        }
            }
}
