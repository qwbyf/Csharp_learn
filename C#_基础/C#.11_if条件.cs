namespace C_._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if条件
            if (true)
            {
                Console.WriteLine("结果1");
            }


            if (false)
            {
                Console.WriteLine("结果2");
            }


            int i = 5;
            if (i > 0)
            {
                Console.WriteLine("结果3");
            }
            else
            {
                Console.WriteLine("结果4");
            }


            //if...   (else if)*n...   (else)...
            //多分支选择     遵循短路原则
            int a = 86;//成绩
            Console.Write("成绩");
            if (a > 90)
            {
                Console.WriteLine("优秀");
            }
            else if (a > 80)
            {
                Console.WriteLine("良好");
            }
            else if (a > 60)
            {
                Console.WriteLine("及格");
            }
            else
            {
                Console.WriteLine("挂科");
            }
            #endregion


            //判断用户输入的字符是否在0~9之间
            //法一
            try
            {
                Console.WriteLine("请输入");
                string c = Console.ReadLine(); //char c = Console.ReadKey().KeyChar;
                int num = int.Parse(c); //int num = int.Parse(c.ToString());
                Console.WriteLine("您输入了一个数字");
            }
            catch
            {
                Console.WriteLine("这不是一个数字");
            }
            //法二
            while (true)
            {
                Console.WriteLine("\n请输入");
                char askii = Console.ReadKey().KeyChar;
                if (askii >= '0' && askii <= '9')
                {
                    Console.WriteLine("\n您输入了一个数字");
                    break;
                }
                else
                {
                    Console.WriteLine("\n这不是一个数字");
                }

            }


            //练习1登陆
            int time = 1;
            while (time <= 3)//最多执行3次
            {
                Console.WriteLine("\n请输入用户名:");
                string name = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                string key = Console.ReadLine();
                if (name == "admin" && key == "8888")
                {
                    Console.WriteLine("登录成功");
                    break;
                }
                else
                {

                    if ((name != "admin"))
                    {
                        Console.WriteLine("用户名不存在!");
                    }
                    else
                    {
                        Console.WriteLine("密码错误!");
                    }
                }
                time++;
                if (time > 3)
                {
                    Console.WriteLine("多次输入错误,暂时不能继续!!");
                }
            }

            //练习2年龄
            while (true)
            {
                try
                {
                    Console.WriteLine("\n请输入你的年龄:");
                    int age = int.Parse(Console.ReadLine());
                    if (age >= 18)
                    {
                        Console.WriteLine("允许查看");
                        break;
                    }
                    else
                    {
                        if (age >= 13)
                        {
                            Console.WriteLine("是否继续查看(yes/no)");
                            string input = Console.ReadLine();
                            if (input == "yes")
                            {
                                Console.WriteLine("请查看");
                            }
                            else
                            {
                                Console.WriteLine("退出");
                            }
                        }
                        else
                        {
                            Console.WriteLine("不允许查看");
                        }
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("请按正确格式输入!");
                }
            }






        }
    }
}
