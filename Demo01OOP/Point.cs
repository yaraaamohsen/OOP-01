using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
    internal struct Point
    {
        //public int X; // ==> Attribute 
        //public int Y;

        //// Constructor : Special Method
        ////              1. Named Like Struct
        ////              2. Has No Return Type

        //// CLR : Will Generate Paramterless Constructor
        //// This Constructor Will Intialized The Attributes With The Default Value (X,Y)

        //// Constructor (Paramterless)
        ////public Point()
        ////{

        ////}

        //// Paramterized Constructor
        //// CLR Still Generate Paramterless Constructor
        //// 
        //public Point()
        //{
        //    // Override the CLR Constructor
        //    X = 8;
        //    Y = 8;
        //}
        //public Point(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}

    }
}
