using System;
using System.Threading;
using static System.Math;

namespace Donut.NET
{
    class Program
    {
        static void Main(string[] args)
        {

           
            double A = 0, B = 0;
            double i, j;
            int k;
                
            double[] z = new double[1760];
            char[] b = new char[1760];

            
            Console.WriteLine("\x1b[2J");
                while (true)
                {
                
                    memset(ref b, Convert.ToChar(32), 1760);
                    memset(ref z, 0, 7040);
                    for (j = 0; j < 6.28; j += 0.07)
                    {
                        for (i = 0; i < 6.28; i += 0.02)
                        {
                            
                            double c = Math.Sin(i);
                            double d = Math.Cos(j);
                            double e = Math.Sin(A);
                            double f = Sin(j);
                            double g = Cos(A);
                            double h = d + 2;
                            double D = 1 / (c * h * e + f * g + 5);
                            double l = Cos(i);
                            double m = Cos(B);
                            double n = Sin(B);
                            double t = c * h * g - f * e;
                            int x = (int)(40 + 30 * D * (l * h * m - t * n));
                            int y = (int)(12 + 15 * D * (l * h * n + t * m));
                            int o = x + 80 * y;
                            int N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));
                            if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
                            {
                                z[o] = D;
                                b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                            }
                        }
                    }
                    Console.WriteLine("\x1b[H");
                    for (k = 0; k < 1761; k++)
                    {
                    if (k % 80 > 0)
                        putchar(b[k]);
                    else
                        putchar(Convert.ToChar(10));
                        A += 0.00004;
                        B += 0.00002;
                    }
                    
                   Thread.Sleep(1);
                //Console.Clear();
            }
                
            static void memset<T>(ref T[] ptr, T value, int size)
            {
                Array.Fill<T>(ptr, value); 
                
            }
            static void putchar(char stdoutchar)
            {
                Console.Write(stdoutchar);
            }

        }
    }
}
