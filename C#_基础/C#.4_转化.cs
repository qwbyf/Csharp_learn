namespace C_._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 括号强转       //数值之间的高精度(大范围)存进低精度(小范围)

            //整型之间
            int i = 255;//注意范围不能超
            byte b = (byte)i;
            Console.WriteLine(b);

            //浮点之间
            double d = 0.1234567890123456789;
            float f = (float)d;
            Console.WriteLine(f);

            //浮点与整型之间
            float ff = 1.123f;
            int ii = (int)ff;//只取整
            Console.WriteLine(ii);

            //数值与字符之间
            int iii = 1;//先定义iii
            iii = 'A';//再对iii重新赋值
            char c = (char)iii;//然后将iii存进char
            Console.WriteLine(iii);
            #endregion

            #region Parse         //把字符存进其他类型
            string s = "123";//这里的123是一串字符
            int iiii = int.Parse(s);//s的值范围要能得存进去才行
            Console.WriteLine(iiii);
            /*或者*/
            string ss = "123";
            Console.WriteLine(int.Parse(ss));//相当于省去了中间碗装碗的一步

            string sss = "True";//得存的进bool才行
            Console.WriteLine(bool.Parse(sss));
            #endregion

            #region Convert       //转化各种类型, Convert.To目标类型, (变量或常量)
            int I = 1;
            I = Convert.ToInt32(false);//转bool
            Console.WriteLine (I);

            I = Convert.ToInt32(1.623);//转浮点, 会四舍五入
            Console.WriteLine (I);

            I = Convert.ToInt32('A');//转char等
            Console.WriteLine (I);

            //SByte->  ToSByte       Byte->   ToByte          char->  ToChar         "float-> ToSingle"
            //short    ToInt16       ushort   ToUInt16        double  ToDouble       
            //int      ToInt32       ...                      string  ToString       "bool->  ToBoolean"
            //long     ToInt64                                                       
            #endregion

            #region Tostring      //其他类型转string
            int a = 1;
            string str = a.ToString();//即把a存进str里
            Console.WriteLine (str);
            str = 1.123f.ToString();
            Console.WriteLine (str);
            str =true.ToString();
            Console.WriteLine (str);
            str ='A'.ToString();
            Console.WriteLine (str);
            #endregion

            //练习题1
            char cc = (char)24069;//括号强转
            Console.WriteLine (cc);
            cc = Convert.ToChar(cc);//convert

            //练习题2
            Console.WriteLine("请输入年龄:");
            string S = Console.ReadLine();//把用户输入的年龄存进S
            int II=Convert.ToInt32(S);//把S转存进整型II
            Console.WriteLine (II);

        }
    }
}
