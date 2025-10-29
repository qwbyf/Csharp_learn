namespace C_._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch分支
            //与if的作用相似,通常使用于枚举
            //dafault像else一样可省略
            //(当变量 == 常量时,执行case与break之间的代码)
            //switch只判断变量是否等于一个固定值,不能写范围/条件运算/逻辑运算等!
            //(case分支可以有无数个)
            //结构:
            /*switch 变量
            {
                case 常量:
                    符合条件执行的代码
                    break;
                case 常量:
                    符合条件执行的代码
                    break;
                default:
                    上述条件都不满足时执行的代码
                    break;
            }*/
            //贯穿:当某些不同条件下执行相同代码时,可以省略break实现简化
            //例:
            int i = 5;
            switch (i)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("不等于");
                    break;
                default:
                    Console.WriteLine("等于");
                    break;
            }
            #endregion

            //练习
            int money = 4000;
            Console.WriteLine("请输入学生评价:");
            string input=Console.ReadLine();
            switch (input)
            {
                case "很兴奋":
                    Console.WriteLine("A级,工资为"+(money+500));
                    break;
                case "很充实":
                    Console.WriteLine("B级,工资为" + money);
                    break;
                case "还好吧":
                    Console.WriteLine("C级,工资为" + (money-300));
                    break;
                case "难理解":
                    Console.WriteLine("D级,工资为" + (money-500));
                    break;
                case "枯燥乏味":
                    Console.WriteLine("E级,工资为" + (money-800));
                    break;
            }

            //练习
            int money2 = 10;
            Console.WriteLine("\n请输入你要购买的型号(中1/大2/超大3):");
            char c=Console.ReadKey().KeyChar;
            Console.WriteLine();//换行
            switch (c)
            {
                case '1':
                    Console.WriteLine($"购买成功,还剩{money2-5}元");
                    break;
                case '2':
                    Console.WriteLine($"购买成功,还剩{money2-7}元");
                    break;
                case '3':
                    Console.WriteLine("购买失败,钱不够,请换其他型号");
                    break;
                default:
                    Console.WriteLine("请正确输入!");
                    break;
            }

            //练习
            Console.WriteLine("请输入成绩:");
            int cj = int.Parse(Console.ReadLine());
            cj /= 10;//非常关键,灵活思路,相当于只取十位,因为会丢掉小数,如8.6 -> 8
            switch (cj)
            {
                case 10:
                case 9:
                    Console.WriteLine("你的成绩是A");
                    break;
                case 8:
                    Console.WriteLine("你的成绩是B");
                    break;
                case 7:
                    Console.WriteLine("你的成绩是C");
                    break;
                case 6:
                    Console.WriteLine("你的成绩是D");
                    break;
                default:
                    Console.WriteLine("你的成绩是E");
                    break;
            }


            //将输入转成字符 再转成字符串 再转成int
            int num = int.Parse(Console.ReadKey().KeyChar.ToString());


        }
    }
}
