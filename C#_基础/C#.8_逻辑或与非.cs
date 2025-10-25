namespace C_._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //逻辑运算符   优先级: 非(!) >> 与(&&) > 或(||)

            #region 与: &&  
            //对两个bool值进行判断: 有假则假,全真为真
            bool result1 = true && false;//F
            bool result2 = true && true ;//T
            Console.WriteLine(result1+"\n"+result2 );

            int i = 5;
            bool result0 = i > 0 && i < 10;//判断i是否在范围内
            Console.WriteLine("\n" + result0);//T
            #endregion

            #region 或: ||
            //对两个bool值进行判断: 有真则真,全假为假
            bool result3 = true  || false;//T
            bool result4 = false || false ;//F
            Console.WriteLine("\n\n\n"+result3 + "\n" + result4);
            #endregion

            #region 非: !
            //对一个bool值进行取反: 真变假,假变真
            bool result5 = !true;//F
            Console.WriteLine("\n\n\n"+result5);

            int ii = 5;
            bool result6 = !(ii>10);//T
            Console.WriteLine(result6);
            #endregion

            #region 复合运算
            bool gameover = false;
            int hp = 100;
            bool isDead = false;
            bool isAlive = true;

            bool result = gameover || hp-90 < 0 && !isDead || isAlive;//优先级: 非(!) >> 与(&&) > 或(||)
            //            gameover || hp-90 < 0 && (true)  || isAlive
            //            gameover ||   (false) &&   true  || isAlive
            //            (false)  || false     &&   true  || (true)
            //             false   ||        (false)       ||  true
            //                   (false)                   ||  true
            //                                           (true)
            Console.WriteLine("\n"+result);//T
            #endregion

            #region 短路原则
            //(由于"与"有假则假, "或"有真则真, 那么后面的内容就不重要了) (如:A选项正确就不看BCD了)
            int a = 5;
            bool result7 = a < 10 || ++a < 5;//a<10为真,而"或(||)"有真则真
            Console.WriteLine("\n\n\n"+result7);//T
            bool result8 = a > 10 && ++a > 5;//a>10为假,而"与(&&)"有假则假
            Console.WriteLine(result8);//F
            #endregion


        }
    }
}
