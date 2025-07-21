using System;
namespace OperatorOverloading
{
   public  class Comparision
    {
        public int X{get;}
        public int Y{get;}

        public Comparision(int x, int y)
        {
            X=X;
            Y=Y;
        }
        public static bool operator ==(Comparision c1, Comparision c2)
        {
            return c1.X == c2.X && c1.Y == c2.Y;
        }

        public static bool operator !=(Comparision c1, Comparision c2)
        {
            return !(c1==c2);
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }
}