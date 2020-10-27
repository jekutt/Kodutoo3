using System;
using Kodutoo3;

namespace kodutoo3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Point point1 = new Point(2, 4);
            Point point2 = new Point(10, 8);
            Point point3 = new Point(15,7);
            point1.Distance(point2);
            point1.Distance(point3);
            point2.Distance(point3);

            Route route1 = new Route();
            route1.create_route();
            route1.add_point(7, 7, 1);
            route1.add_point(15, 3, 2);
            route1.get_length();


        }
    }
}