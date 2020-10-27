using System;
using System.Collections.Generic;
using System.Text;
using kodutoo3;

namespace Kodutoo3
{
    public class Route : Point
    {
        public int _index;
        public List<Point> ListOfPoints;
        public double _dist;
        public Route()
        {
            ListOfPoints = new List<Point>();
        }

        public void create_route()
        {
            _index = 0;
            Console.WriteLine("The new route is created!");
        }

        public string add_point(double x, double y, int index)
        {
            ListOfPoints.Insert(index - 1, new Point(x, y));
            _index += 1;
            Point P = new Point(ListOfPoints[index - 1]._x, ListOfPoints[index - 1]._y);
            string coordinates = ListOfPoints[index - 1]._x + ", " + ListOfPoints[index - 1]._y;
            return coordinates;
        }

        public void remove_point(int index)
        {
            ListOfPoints.RemoveAt(index-1);
            _index -= 1;
        }

        public double get_length()
        {
            if (_index <= 1)
            { 
                _dist = 0;
            }
            else
            { 
                for (int i = 1; i < _index; i++)
                {
                    _dist += ListOfPoints[i-1].Distance(ListOfPoints[i]);
                }
            }
            Console.WriteLine("The length is {0}", _dist);
            return _dist;

        }
    }
}
