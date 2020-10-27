using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace kodutoo3
{
    public class Point
    {
        public double _x;
        public double _y;


        public Point(double x, double y)
        {
            _x = x;
            _y = y;
            CreateRho();
            CreateTheta();
        }
        public Point()
        {
        }

        public string Print()
        {
            Console.WriteLine("X = {0}", _x);
            Console.WriteLine("Y = {0}", _y);
            Console.WriteLine("Rho = {0}", CreateRho());
            Console.WriteLine("Theta = {0}", CreateTheta());
            return  "X: " + _x + "\n" +
                    "Y: " + _y + "\n" +
                    "Rho: " + CreateRho() + "\n" +
                    "Theta: " + CreateTheta();
        }

        public double X()
        {
            _x = CreateRho() * Math.Cos(Math.Atan2(_y, _x));
            return _x;
        }
        public double Y()
        {
            _y = CreateRho() * Math.Sin(Math.Atan2(_y, _x));
            return _y;
        }
        public double CreateRho() //"Distance to origin (0, 0)"
        {
            double _rho = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
            return _rho;
        }

        public double CreateTheta() //"Angle to horizontal axis"
        {
           double _theta = Math.Atan2(_y, _x);
           return _theta;
        }

        public double Distance(Point p2) //"Distance to other"
        {
            double _dist = Math.Sqrt(Math.Pow(this._x - p2._x, 2) + Math.Pow(this._y - p2._y, 2));
            Console.WriteLine("Distance between Points = {0}", _dist);
            return _dist;
        }

        public Point VectorTo(Point p2) //"Returns the Point representing the vector from self to other Point"
        {
            Point P = new Point(this._x - p2._x, this._y - p2._y);
            Console.WriteLine("P({0}; {1})", P._x, P._y);
            return P;
        }

        public Point Translate(double dx, double dy) //"Move by dx horizontally, dy vertically"
        {
            Point P = new Point(this._x + dx, this._y + dy);
            Console.WriteLine("Point({0}; {1}) moved to ({2}; {3})", _x - dx, _y - dy, _x, _y);
            return P;
        }

        public Point Scale(double factor) //"Scale by factor"
        {
            Point P = new Point(this._x * factor, this._y * factor);
            Console.WriteLine("Point({0}; {1}) scaled to ({2}; {3}), Factor = {4}", _x / factor, _y / factor, _x, _y, factor);
            return P;
        }

        public Point Centre_rotate(double angle)
        {
            Point P = new Point(CreateRho() * Math.Cos(CreateTheta() + angle), CreateRho() * Math.Sin(CreateTheta() + angle));
            return P;
        }
        public Point Rotate(Point p1, double angle)
        {
            Point B = new Point(_x - p1._x, _y - p1._y).Centre_rotate(angle);
            B._x += p1._x;
            B._y += p1._y;
            Console.WriteLine("P({0}; {1})", B._x, B._y);
            return B;
        }
    }
}