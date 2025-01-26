using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.first_project
{
    using System;

    class Point3D : ICloneable, IComparable<Point3D>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // Constructors
        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Override ToString
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        // Override Equals and GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        // Overload == and != operators
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        // Implement IComparable
        public int CompareTo(Point3D other)
        {
            if (X != other.X)
            {
                return X.CompareTo(other.X);
            }
            return Y.CompareTo(other.Y);
        }

        // Implement ICloneable
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }

   

}
