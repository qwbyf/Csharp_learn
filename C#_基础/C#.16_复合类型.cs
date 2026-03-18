namespace C_._16
{
    internal class Program
    {
        //值类型-复合类型  注意位置在 Program类内部 与 方法(函数)外部

        // 一:枚举类型
        enum week
        {
            week1,
            week2,
            week3,
            week4,
            week5,
            week6,
            week7,
        }
        // 二:结构类型(多个相关变量需要重复声明时,进行简化,方便管理)
        struct student
        {
            public string name;
            public int age;
            public string ID;
        }
        static void Main(string[] args)
        {
            // 一
            week day = week.week3;
            Console.WriteLine($"今天是{day}");

            // 二
            student s1, s2;
            s1.name = "小明";
            s1.age = 18;
            s1.ID = "123456";

            s2.name = "小刚";
            s2.age = 19;
            s2.ID = "234567";

            Console.WriteLine($"\ns1同学的姓名:{s1.name}" + $"\ns1同学的年龄:{s1.age}" + $"\ns1同学的学号:{s1.ID}");
            Console.WriteLine($"\ns2同学的姓名:{s2.name}" + $"\ns2同学的年龄:{s2.age}" + $"\ns2同学的学号:{s2.ID}");
        }
    }
}
