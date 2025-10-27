namespace C_._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 三目运算符   //某些简单情况下可以替代if语句
            //格式:     真假 ? 真选我 : 假选我;

            int i = 5;

            string str = i > 0 ? "正确" : "错误";
            Console.WriteLine(str);
            str = i < 0 ? "正确" : "错误";
            Console.WriteLine(str);

            int j = i > 0 ? 1 : 0;
            Console.WriteLine(j);
            j = i < 0 ? 1 : 0;
            Console.WriteLine(j);

            #endregion

            //练习题
            //找出更大的数
            Console.WriteLine("\n请输入两个数");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());

            int c = num1 > num2 ? num1 : num2;
            Console.WriteLine("更大的数是: " + c);


            #region //小猫哈气定律
            Console.Write("\n(头顶有掩体:1;头顶无掩体:0) 请输入: ");
            int ii = int.Parse(Console.ReadLine());
            Console.Write("(有人摸:1;没人摸:0) 请输入: ");
            int jj = int.Parse(Console.ReadLine());

            bool result1 = ii > 0;//T
            bool result2 = jj > 0;//T
            string str0 = result1 && result2 ? "哈气" : "不哈气";
            Console.WriteLine("\n小猫" + str0);
            //优化后
            while (true)
            {
                try
                {
                    Console.WriteLine("\n头顶是否有掩体？(有:true; 无:false)");
                    bool hasCover = bool.Parse(Console.ReadLine());
                    Console.WriteLine("是否有人摸？(有:true; 无:false)");
                    bool isTouched = bool.Parse(Console.ReadLine());
                    string action = (hasCover && isTouched) ? "哈气" : "不哈气";// 哈气定律：当头顶有掩体且被摸时哈气
                    Console.WriteLine($"小猫{action}");

                    break;
                }

                catch
                {
                    Console.WriteLine("\n请按规则输入!");
                }
            }
            #endregion


            //判断闰年
            Console.WriteLine("\n请输入年份");
            int year=int.Parse(Console.ReadLine());
            string result = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) ? "是" : "不是";
            Console.WriteLine($"{result}闰年");


        }
    }
}
