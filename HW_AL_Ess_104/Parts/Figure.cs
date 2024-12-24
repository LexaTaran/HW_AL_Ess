using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AL_Ess_104.Parts
{
    class Figure
    {
        private Point [] _points; 


        public Figure(params Point[] points)
        {
            _points = points;
        }

        private double LengthSide (Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        private string NameSize(Point a, Point b)
        {
            return a.Name + b.Name;
        }
        public void PerimeterCalculator()
        { 
            double perimeter = 0;
            for (int i = 0; i < _points.Length - 1; i++)
            {
                perimeter += LengthSide(_points[i], _points[i + 1]);
            }
            perimeter += LengthSide(_points[_points.Length - 1], _points[0]);

            Console.WriteLine($"Perimeter is: {perimeter}"); 
        }
        private string PerimeterName()
        {
            string nameSize  = string.Empty;
            for (int i = 0; i < _points.Length - 1; i++)
            {
                nameSize += NameSize(_points[i], _points[(i + 1)]);
            }
            return nameSize;
        }

        public void PrintName() 
        { 
            Console.WriteLine($"Название многогранника с {PerimeterName()} вершинами"); 
        }
    }
}
