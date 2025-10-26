namespace C_._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //位运算(以二进制形式运算)

            #region 位与: &  //上下对位,有0则0

            int a1 = 1;//001
            int b1 = 5;//101
            int c1 = a1 & b1;
            //      001
            //  &   101
            //      001
            Console.WriteLine(c1);//c=1

            #endregion

            #region 位或: |  //上下对位,有1则1

            int a2 = 1;//001
            int b2 = 5;//101
            int c2 = a2 | b2;
            //      001
            //  |   101
            //      101
            Console.WriteLine(c2);//c=5

            #endregion

            #region 异或: ^  //上下对位,同0异1

            int a3 = 1;//001
            int b3 = 5;//101
            int c3 = a3 ^ b3;
            //      001
            //  ^   101
            //      100
            Console.WriteLine(c3);//c=4

            #endregion

            #region 位取反: ~  //完整位数,0变1,1变0

            int a4 = 1;//001   int有32位(第一位是符号位)
            int c4 = ~a4;
            //      0000 0000 0000 0000 0000 0000 0001
            //  ~   1111 1111 1111 1111 1111 1111 0110
            Console.WriteLine(c4);//c= -2

            #endregion

            #region 移位
            //      左移:<<   //左移几位,右侧补几个0
            //      右移:>>   //右移几位,右侧丢掉几个数

            int i = 1;//001

            int z = i << 5;
            //      001      
            // 00100000        
            Console.WriteLine(z);//z= 32
            int y = i >> 1;
            //      001
            //       00 
            Console.WriteLine(y);//y= 0

            #endregion


        }
    }
}
