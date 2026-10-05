namespace OperatorOverloading;

internal class Point : IEquatable<Point>, IComparable<Point>
{
    public int X { get; set; }

    public Point()
    {
    }

    public Point(int x)
    {
        X = x;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X);
    }

    public bool Equals(Point? other) => other is not null && X == other.X;

    public override bool Equals(object? obj) => Equals(obj as Point);

    // Όταν κάνεις override την Equals, πρέπει να κάνεις και την GetHashCode:
    // δύο "ίσα" αντικείμενα πρέπει να έχουν ίδιο hash code (χρειάζεται σε HashSet / Dictionary)
    public override int GetHashCode() => X.GetHashCode();

    // Για να τυπώνεται ωραία, π.χ. "Point(7)" αντί για "OperatorOverloading.Point"
    public override string ToString() => $"Point({X})";

    public int CompareTo(Point? other)
    {
        if (other is null) return 1;
        return X.CompareTo(other.X);
    }

    public static int Compare(Point? p1, Point? p2)
    {
        if (ReferenceEquals(p1, p2)) return 0;
        if (p1 is null) return -1;
        return p1.CompareTo(p2);
    }

    public static bool operator ==(Point? p1, Point? p2)
    {
        if (ReferenceEquals(p1, p2)) return true;
        if (p1 is null || p2 is null) return false;
        return p1.Equals(p2);
    }

    public static bool operator !=(Point? p1, Point? p2) => !(p1 == p2);

    public static bool operator <(Point? p1, Point? p2) => Compare(p1, p2) < 0;
    public static bool operator >(Point? p1, Point? p2) => Compare(p1, p2) > 0;
    public static bool operator <=(Point? p1, Point? p2) => Compare(p1, p2) <= 0;
    public static bool operator >=(Point? p1, Point? p2) => Compare(p1, p2) >= 0;
}   

