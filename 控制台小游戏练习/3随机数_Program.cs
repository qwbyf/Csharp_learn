namespace 随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 随机数
            //Random r = new Random();//创建随机数对象,r是变量名

            //int a = r.Next(100);//生成一个非负数的随机数,范围是[0,100),左闭右开
            //Console.WriteLine(a);
            //int b = r.Next(5,100);//范围是[5,100),左闭右开
            //Console.WriteLine(b);

            //练习:打怪
            //设置小怪兽数值
            int monster_Def = 10;//防御力
            int monster_HP = 20;//生命值
            //设置主角数值
            Random r = new Random();
            
            for (; monster_HP > 0; )
            {
                Console.WriteLine("按任意键继续");
                Console.ReadKey();
                int ATK = r.Next(9, 13);//攻击力
                int hurt = ATK - monster_Def;
                if (hurt > 0)
                {
                    monster_HP -= hurt;
                    Console.WriteLine($"你造成了{hurt}点伤害,小怪兽当前生命值为{monster_HP}");
                }
                else
                {
                    Console.WriteLine($"你的攻击收效甚微,小怪兽当前生命值为{monster_HP}");
                }
                if (monster_HP <= 0)
                {
                    Console.WriteLine("\n怪兽已死亡,你成功了!");
                }
            }
            
            #endregion
        }
    }
}
