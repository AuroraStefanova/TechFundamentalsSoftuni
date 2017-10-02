using System;


namespace _04.VolumeOfPyramid
{
    class VolumeOfPyramid
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double widht = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double pyramid = (length * widht * height) / 3;
            Console.WriteLine($"Pyramid Volume: {pyramid:F2}");
        }
    }
}
