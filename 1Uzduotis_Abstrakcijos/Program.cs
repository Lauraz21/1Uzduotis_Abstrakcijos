namespace _1Uzduotis_Abstrakcijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            Triangle triangle = new Triangle(2,5,3);

            WriteShapeStuff(square, "Square");
            WriteShapeStuff(triangle, "Triangle");
        }

        private static void WriteShapeStuff(GeometricShape shape, string name)
        {
            Console.WriteLine($"{name} area: {shape.GetArea()}");
            Console.WriteLine($"{name} perimeter: {shape.GetPerimeter()}");
        }
    }
}