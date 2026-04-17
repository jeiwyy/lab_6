internal class RightTriangle
{
    private double a;
    private double b;

    public RightTriangle()
    {
        a = 2;
        b = 2;
    }

    public RightTriangle(double a, double b)
    {
        if (a > 0 && b > 0)
        {
            this.a = a;
            this.b = b;
        }
        else
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }

    public double A
    {
        get 
        { 
            return a; 
        }
        set
        {
            this.a = value;
        }
    }
    public double B
    {
        get 
        { 
            return b; 
        }
        set
        {
            this.b = value;
        }
    }

    public double CalcArea()
    {
        if (a > 0 && b > 0)
        {
            return a * b / 2;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return "a = " + a + " b = " + b;
    }

    public static RightTriangle operator ++(RightTriangle triangle)
    {
        return new RightTriangle(triangle.a * 2, triangle.b * 2);
    }

    public static RightTriangle operator --(RightTriangle triangle)
    {
        return new RightTriangle(triangle.a / 2, triangle.b / 2);
    }

    public static explicit operator double(RightTriangle triangle)
    {
        if (triangle.a > 0 && triangle.b > 0)
        {
            return triangle.CalcArea();
        }
        else
        {
            return -1;
        }
    }

    public static implicit operator bool(RightTriangle triangle)
    {
        if (triangle.a > 0 && triangle.b > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator <=(RightTriangle a, RightTriangle b)
    {
        return a.CalcArea() <= b.CalcArea();
    }

    public static bool operator >=(RightTriangle a, RightTriangle b)
    {
        return a.CalcArea() >= b.CalcArea();
    }
}