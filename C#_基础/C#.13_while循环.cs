using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace C_._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while循环
            ////在实际应用中避免出现死循环,会无限重复循环导致程序崩溃闪退或卡死
            //int i = 1;
            //while (i < 10)
            //{
            //    ++i;
            //}
            //Console.WriteLine(i);

            ////流程控制关键词
            ////break, continue(跳过后面,继续下一次循环)
            ////练习: 打印0~20之间的奇数
            //int num = 0;
            //while (num < 20)
            //{
            //    ++num;//得到0~20的数
            //    if (num % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(num);
            //}

            ////嵌套示例
            //int a = 0;
            //int b = 0;
            //while (a < 10)
            //{
            //    ++a;
            //    if (b < 10)//if换成while也可以
            //    {
            //        ++b;
            //    }
            //}
            //Console.WriteLine($"a={a},b={b}");
            #endregion

            #region 重点!!!
            /*int a2 = 0;
            while (a2 < 10)
            {
                ++a2;
                int b2 = 0;
                while (b2 < 10)
                {
                    ++b2;
                }
                //局部变量b2执行完后就销毁了
            }
            //逻辑是a2=0进循环变为1,然后b2进循环直到加到10后出循环,此b2被销毁,然后a2=1回到循环重复直到a2=10
            //过程中新命名了10个b2,并都销毁掉了,总共重复了10*10=100次 "++b2"
            Console.WriteLine($"a2={a2},b2={b2}");  //之前的局部变量b2都销毁了,所以现在没有b2了*/
            #endregion



            #region 练习//求和
            //int number = 0;
            //int sum = 0;
            //while (number < 100)
            //{
            //    ++number;
            //    Console.WriteLine(number);
            //    sum = sum + number;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习//求和变式
            //int number = 0;
            //int sum = 0;
            //while (number < 100)
            //{
            //    ++number;
            //    if (number % 7 == 0)
            //    {
            //        continue;//排除能被7整除的数
            //    }
            //    sum = sum + number;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习//质数判断
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入一个数:");
            //        int input = int.Parse(Console.ReadLine());
            //        int ii = 2;
            //        while (ii < input)
            //        {
            //            if (input % ii == 0)
            //            {
            //                break;
            //            }
            //            ++ii;
            //        }
            //        if (ii != input)
            //        {
            //            Console.WriteLine("不是质数");
            //        }
            //        else
            //        {
            //            Console.WriteLine("是质数");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请正确输入!");
            //    }
            //}
            #endregion

            #region 练习//成绩
            //Console.WriteLine("\n请输入班级人数");
            //int man = int.Parse(Console.ReadLine());
            //int time = 1;//计数器
            //int n = 1;//序号
            //int sum_cj = 0;
            //float average_cj = 0;
            //while (time <= man)
            //{
            //    Console.WriteLine($"请输入第{n}个同学的成绩");
            //    int cj = int.Parse(Console.ReadLine());
            //    sum_cj += cj;
            //    time++;
            //    n++;
            //}
            //average_cj = sum_cj / man;
            //Console.WriteLine($"总成绩={sum_cj}" + $"\n平均成绩={average_cj}");
            #endregion

            #region 练习//增长率
            //int person = 100;
            //int month = 0;
            //while (true)
            //{
            //    month++;
            //    if (person * (Math.Pow(1.2, month)) <= 1000)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"要经历{month}个月,观看人数才能达到1000人以上");
            //        break;
            //    }
            //}
            #endregion

            #region 练习//数列
            //int num1 = 1;
            //int num2 = 1;
            //int nUm;
            //int N = 2;
            //while (true)
            //{
            //    nUm = num1 + num2;//2,3,5
            //    num1 = num2;//1,2,3
            //    num2 = nUm;//2,3,5
            //    N++;
            //    if (N == 20)
            //    {
            //        Console.WriteLine($"\n第{N}位数是: {num2}");
            //        break;
            //    }
            //}
            #endregion

            #region 练习//质数之和
            int num = 2;
            int sum = 0;
            while (num <= 100)//2+3+5+7=17
            {
                int i = 2;
                while (i <= num)
                {
                    if (num % i == 0)
                    {
                        break;
                    }
                    ++i;
                }
                if (i == num)
                {
                    sum = sum + i;
                }             
                num++;
            }
            Console.WriteLine($"1~100的质数之和为:{sum}");
            #endregion

        }
    }
}
