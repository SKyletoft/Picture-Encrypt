using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var longestWord = 0;
        for (var i = 0; i < input.Length; i++)
        {
            longestWord = Math.Max(longestWord, input[i].Length);
        }
        var image = new Bitmap(longestWord, input.Length);
        for (var i = 0; i < input.Length; i++)
        {
            for (var j = 0; j < input[i].Length; j++)
            {
                image.SetPixel(j, i, Color.FromArgb(255, (int)input[i][j], (int)input[i][j], (int)input[i][j]));
            }
        }
        image.Save("outputImage.png");
    }
}