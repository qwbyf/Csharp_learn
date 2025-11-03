using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace C_._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for循环
            //for ( 任意个临时变量; 条件判断; 每次循环后执行的代码 )
            //{
            //}


            //质数
            //int i = 2;
            //int sum = 0;
            //for (int time=1; time<100;time++)
            //{
            //    int n = 2;
            //    for ( ; n<i; n++)
            //    {
            //        if (i % n == 0)
            //        {
            //            break;
            //        }                    
            //    }                
            //    if (n == i)
            //    {
            //        Console.WriteLine(i);
            //        sum = sum + i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion


            #region 练习//求和
            //int sum = 0;
            //for (int n=1; n<=100; n++)
            //{
            //    Console.WriteLine(n);                
            //    if (n % 2 == 0)
            //    {
            //        sum = sum + n;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习//水仙花数
            //int bai, sghi, ge;
            //for (int n=100; n<=999; n++)
            //{
            //    bai = n / 100;
            //    shi = (n % 100) / 10;
            //    ge = n % 10;
            //    if (n == bai*bai*bai + shi*shi*shi + ge*ge*ge)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}
            #endregion

            #region 练习//九九乘法表            
            //for (int j = 1; j <= 9; j++)
            //{
            //    for (int i = 1; i <= 9; i++)
            //    {
            //        if (i <= j)
            //        {
            //            Console.Write($"{i}*{j}={i * j}  ");
            //        }                    
            //    }
            //    Console.WriteLine();
            //}   
            #endregion

            //练习: 打印图案(注意行列分析)
            #region 练习一            
            //for (int i=1; i<=10 ; i++)//行
            //{
            //    for (int j = 1; j <= 10; j++)//列
            //    {
            //        if (i == 1 || i == 10)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            if (j == 1 || j == 10)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //} 
            #endregion
            #region 练习二   
            // 法1
            //for (int i = 0; i < 10; i++)//
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        Console.Write("*");
            //        if (j == 0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

            // 法2 !!
            //for (int i = 1; i <= 10; i++)//行
            //{
            //    for (int j = 1; j <= i; j++)//列
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 练习三
            ////法一:  关键:第十列(中间)的10行都要打印,向两边递减
            
            //int put1 = 10, put2 = 10;
            //for (int i = 1; i <= 10; i++)//行
            //{
            //    for (int j = 1; j <= 20; j++)//列
            //    {
            //        if (j >= put1 && j <= put2)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    put1--;
            //    put2++;
            //    Console.WriteLine();
            //}

            ////法二:                行数i    *个数j    空格数k
            //          *           1        1         9
            //         ***          2        3         8
            //        *****         3        5         7
            //       *******        4        7         6
            //      *********       5        9         5
            //     ***********      6        11        4
            //    *************     7        13        3
            //   ***************    8        15        2
            //  *****************   9        17        1
            // *******************  10       19        0
            //规律:    2i-1      10-i  

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int k = 1; k <= 10 - i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i * 2 - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


        }
    }
}
