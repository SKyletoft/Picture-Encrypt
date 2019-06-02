using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        var image = new Bitmap("0xF1L3.png");
        for (var i = 0; i < image.Height; i++)
        {
            for (var j = 0; j < image.Width; j++)
            {
                Console.Write((char)(image.GetPixel(j, i).R));
            }
            Console.WriteLine();
        }
    }
}