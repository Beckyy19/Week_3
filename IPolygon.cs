using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    internal interface IPolygon
    {
        string Name
        {
            get;
            set;
        }

        int NumOfSides
        {
            get;
            //private set will nor work but we'll define it a derived class from the interface
        }

        void calculateArea(params int[] sides);
    }

    interface Icolor
    {
        void getColor();
    }

 
}


