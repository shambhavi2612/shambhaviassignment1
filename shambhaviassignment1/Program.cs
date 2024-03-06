
using System;

class Patterns
{
    // Square Hollow Pattern
    static void SquareHollowPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == 1 || i == n || j == 1 || j == n)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // Number triangle Pattern
    static void NumberTrianglePattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int k = 1; k <= i; k++)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }

    // Number-increasing Pyramid Pattern
    static void NumberIncreasingPyramidPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");
            Console.WriteLine();
        }
    }

    // Number-increasing reverse Pyramid Pattern
    static void NumberIncreasingReversePyramidPattern(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");
            Console.WriteLine();
        }
    }

    // Number-changing Pyramid Pattern
    static void NumberChangingPyramidPattern(int n)
    {
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }

    // Zero-One Triangle Pattern
    static void ZeroOneTrianglePattern(int n)
    {
        int start = 1;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)

                start = 1;
            else
                start = 0;

            for (int j = 0; j <= i; j++)
            {
                Console.Write(start);
                start = 1 - start;
            }
            Console.WriteLine();
        }
    }
    

    // Palindrome Triangle Pattern
    static void PalindromeTrianglePattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int num = i;
            for (int j = 1; j <= n - i; j++)
                Console.Write("  ");
            for (int k = 1; k <= i; k++)
                Console.Write(num-- + " ");
            num = 2;
            for (int l = 2; l <= i; l++)
                Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }

    // Rhombus Pattern
    static void RhombusPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int k = 1; k <= n; k++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    // Diamond Star Pattern
    static void DiamondStarPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("*");
            Console.WriteLine();
        }
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    // Mirror Image Triangle Pattern
    static void MirrorImageTrianglePattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            
            for (int j = 1; j < i; j++)
            {
                Console.Write(" ");
            }

           
            for (int j = i; j <= n; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }

        
        for (int i = n - 1; i >= 1; i--)
        {
           
            for (int j = 1; j < i; j++)
            {
                Console.Write(" ");
            }

           
            for (int j = i; j <= n; j++)
            {
                Console.Write(j + " ");
            }


            Console.WriteLine();
        }
    }

    // Hollow Triangle Pattern
    static void HollowTrianglePattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                if (k == 1 || k == 2 * i - 1 || i == n)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }

    static void HollowReverseTrianglePattern(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");

            
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                if (k == 1 || k == 2 * i - 1 || i == n)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }

    // Hollow Diamond Pyramid
    static void HollowDiamondPyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                if (k == 1 || k == 2 * i - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                if (k == 1 || k == 2 * i - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // Hollow Hourglass Pattern
    static void HollowHourglassPattern(int n)
    {
        for (int i = 0; i < n; i++)
        {
            
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            
            for (int j = 0; j < n - i; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }

            Console.WriteLine();
        }

        
        for (int i = n - 2; i >= 0; i--)
        {
            
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

           
            for (int j = 0; j < n - i; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }

            Console.WriteLine();
        }
    }

    // Pascal's Triangle
    static void PascalsTriangle(int n)
    {
       
        for (int i = 1; i <= n; i++)
        {
            int b = 1;
            for (int j = 0; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write(b + " ");
                b = b * (i - k) / k;
            }
            Console.WriteLine();
        }
    }



    // Main method
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number");
         int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n);

        
        SquareHollowPattern(n);
        Console.WriteLine();
        NumberTrianglePattern(n);
        Console.WriteLine();
        NumberIncreasingPyramidPattern(n);
        Console.WriteLine();
        NumberIncreasingReversePyramidPattern(n);
        Console.WriteLine();
        NumberChangingPyramidPattern(n);
        Console.WriteLine();
        ZeroOneTrianglePattern(n);
        Console.WriteLine();
        PalindromeTrianglePattern(n);
        Console.WriteLine();
        RhombusPattern(n);
        Console.WriteLine();
        DiamondStarPattern(n);
        Console.WriteLine();
        MirrorImageTrianglePattern(n);
        Console.WriteLine();
        HollowTrianglePattern(n);
        Console.WriteLine();
        HollowReverseTrianglePattern(n);
        Console.WriteLine();
        HollowDiamondPyramid(n);
        Console.WriteLine();
        HollowHourglassPattern(n);
        Console.WriteLine();
        PascalsTriangle(n);
    }
}
