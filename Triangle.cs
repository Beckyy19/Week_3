using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Triangle : IPolygon, Icolor
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private int _numOfSides;
        public int NumOfSides
        {
            get => _numOfSides;
            private set => _numOfSides = value;
        }

        public void calculateArea(int[] sides)
        {
            var s =(sides[0]+sides[1]+sides[2])/2;
            double area = Math.Sqrt(s*(s- sides[0]) *(s- sides[1]) *(s- sides[2]));

            Console.WriteLine("Area of Triangle is" + area);
            //int area = sides[0] * sides[1];
            //Console.Write("Area of Rectangle:" + area);
        }

        public void getColor()
        {
            Console.WriteLine("Green Rectangle");
        }
        public Triangle() => _numOfSides = 3;
    }
}
