namespace C_._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 除法注意事项
            //除法会丢失精度,因为整数默认是int型,则结果也只会保留整数
            int i = 1 / 2;
            Console.WriteLine(i);//0.5最后输出0
            //如果要输出小数,则运算式中要有浮点数
            float ii = 1f/2;//或 1/2f 或 1f/2f
            Console.WriteLine(ii);
            #endregion

            #region 乘方
            double mi = Math.Pow(2, 3);//float -> MathF.Pow
            Console.WriteLine(mi);
            #endregion

            #region 自增/自减运算符    //对自己+1或-1
            int a = 1;
            Console.WriteLine(a++);//先用再加: 先输出1, 后续a变为2
            a = 1;
            Console.WriteLine(++a);//先加再用: 先a变成2, 再输出2
            a = 1;
            Console.WriteLine(a--);
            a = 1;
            Console.WriteLine(--a);
            #endregion

            //练习题
            //一
            int r = 5;
            float S = 3.14f * r * r;
            float C = 3.14f * 2 * r;
            Console.WriteLine("\n面积="+S+"\n周长="+C);

            //二
            int i1 = 90,
                i2 = 100, 
                i3 = 70;
            float zong = i1 + i2 + i3,
                  pin=zong/3;
            Console.WriteLine("\n总分="+zong+"\n平均分="+pin);

            //三
            int T = 285, K = 720,//单价
                Tj = 0, Kj = 0;//件数

            Console.Write("\n您购买了多少件T恤:");
            Tj = int.Parse(Console.ReadLine());
            Console.Write("您购买了多少件裤子:");
            Kj = int.Parse(Console.ReadLine());

            float Z = T * Tj + K * Kj;//总价
            Console.WriteLine("您需支付:" + Z + "元");
            Z = (T * Tj + K * Kj) * (3.8f / 10);//打折
            Console.WriteLine("打3.8折后您只需支付:" + Z + "元");

            //四
            //我:
            /*int ss = 987652;
            int s, m, h, t;
            t = ss / (60 * 60 * 24);
            h = (ss - t * 24 * 60 * 60) / (60 * 60);
            m = (ss - t * 24 * 60 * 60 - h * 60 * 60) / 60;
            s = (ss - t * 24 * 60 * 60 - h * 60 * 60 - m * 60);
            Console.WriteLine("\n987652秒即: " + t + "天" + h + "小时" + m + "分" + s + "秒");*/
            //改:
            int ss = 987652;
            int onedayS =24*60*60,
                onehourS =60*60,
                oneminS = 60;

            int day, hour, min, s;
            day = ss / onedayS;
            hour = ss % onedayS / onehourS;
            min = ss % onehourS / oneminS;
            s = ss % oneminS;
            Console.WriteLine("\n987652秒即: " + day + "天" + hour + "小时" + min + "分" + s + "秒");


            //五
            int a2 = 87, b2 = 99;
            int cha = a2 - b2;
            a2 = a2 - cha;
            b2 = b2 + cha;
            Console.WriteLine("\na2=" + a2 + "\nb2=" + b2);


        }
    }
}
