namespace C_._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //异常捕获

            try//希望进行异常捕获的代码
            {
                Console.WriteLine("请输入用户名:");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                Console.WriteLine(i);

            }
            catch//异常后执行的代码
            {
                Console.WriteLine("用户名错误,请输入数字" + "\n请重新输入:");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                Console.WriteLine(i);

            }
            finally//无论是否异常最终都执行的代码 
            { Console.WriteLine("输入完毕"); }
        }
    }
}
