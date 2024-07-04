using System;
using System.Text;

public abstract class Shape
{
    private int _so_dinh;

    public int so_dinh
    {
        get { return _so_dinh; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Số đỉnh phải lớn hơn 0.");
            }
            _so_dinh = value;
        }
    }

    public Shape(int soDinh)
    {
        so_dinh = soDinh;
    }
}

public class TamGiac : Shape
{
    public TamGiac() : base(3) // Tam giác luôn có 3 đỉnh
    {
    }

    public new int so_dinh
    {
        get { return 3; } // Tam giác luôn có 3 đỉnh
        set
        {
            if (value != 3)
            {
                throw new ArgumentException("Số đỉnh của tam giác phải là 3.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            Shape shape = new TamGiac();
            Console.WriteLine($"Số đỉnh của tam giác: {shape.so_dinh}");

            // Thử gán số đỉnh không hợp lệ
            shape.so_dinh = 4; // Điều này sẽ ném ra ArgumentException
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
