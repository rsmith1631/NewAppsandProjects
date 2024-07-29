using System;

namespace PyramidApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("********************  Build Your Own Pyramid!  **************************");
        Console.WriteLine("*************************************************************************");

        Console.WriteLine("*");

        Console.Write("Choose the height of your Pyramid: ");
        int height = Convert.ToInt32(Console.ReadLine());

        BuildMyPyramid(height);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Your pyramid looks great!");

        Console.ReadLine();
    }

    private static void BuildMyPyramid(int size)
    {
        for (int y = 1; y <= size; y++)
        {
            // variable h for Hyphens on the left
            // This loops then subtract the number of hyphens(y) by size of the pyramid UserInput will be size
            for (int h = 1; h <= size - y; h++)
            {

                Console.Write("-");
            }
            // variable p is used to draw the Pyramid
            // p creates the pyramid with the # when p <= y being the loop index times 2 minus 1.
            for (int p = 1; p <= ((y * 2) - 1); p++)
            {
                Console.Write("#");
            }
            // variable h is used again for the Hyphens on the right
            for (int h = 1; h <= size - y; h++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }
    }
}



