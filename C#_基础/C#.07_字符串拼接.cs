namespace C_._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //字符串拼接
            int i = 11;
            
            string str = string.Format("现在是{0}点,{1}安,{2}阁下", i, "午", "开拓者");//{0}是占位符,将后面的内容依次对应填入
            Console.WriteLine(str);
            //或直接
            Console.WriteLine("现在是{0}点,{1}安,{2}阁下", i, "午", "开拓者");
            //或
            Console.WriteLine($"现在是{i}点");//字符串插值法



        }
    }
}
