using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

class Program
{
    static void Main()
    {
        Shape myShape = new Shape();
        Shape myCircle = new Circle();
        Shape mySquare = new Square();

        myShape.Draw();
        myCircle.Draw();
        mySquare.Draw();
    }
}
