using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        

        public void Input()
        {
            Console.Write("Введите название: ");
            Title = Console.ReadLine();
            Console.Write("Введите адрес: ");
            Address = double.Parse(Console.ReadLine());
            Console.Write("Введите год открытия: ");
            YearOfOpening = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Название " + Title + "\nПлощадь: " + Address + "\n Продолжительность" + YearOfOpening);
        }
    }

}
