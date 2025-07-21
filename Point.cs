using System;
namespace OperatorOverloading
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Overloading the + operator
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        // Overloading the - operator
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }


        public static Point operator *(Point p, double scalar)
        {
            return new Point(p.X * scalar, p.Y * scalar);

        }

        public static Point operator /(Point p , double scalar)
        {
            if(scalar==0) throw new DivideByZeroException("cannot divide by zero");
            return new Point(p.X/scalar,p.Y/scalar);
        }

        // Overriding ToString for easy output
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}