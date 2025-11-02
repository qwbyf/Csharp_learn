namespace C_._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region do while 循环  //先斩后奏: 先至少执行一次,再判断是否继续循环
            int i1 = 1; 
            do
            {                
                Console.WriteLine(i1);//1,2
                i1++;
            } while (i1 < 3);


            //练习
            string name, key;
            bool judge = false;
            do
            {
                if (judge)
                {
                    Console.WriteLine("用户名或密码错误,请重新输入!");
                }
                judge = true;
                Console.WriteLine("请输入用户名:");
                name = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                key = Console.ReadLine();

            } while (name != "admin" && key != "8888");
            #endregion
        }
    }
}
