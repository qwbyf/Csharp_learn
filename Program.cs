namespace C_._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 变量名
            //有符号
            sbyte sby = 127;
            int i = -1;//整型
            short s = -2;//短整型
            long l = -3;//长整型
            //无符号
            byte by = 255;
            uint ui = 1;
            ushort us = 2;
            ulong ul = 3;
            //浮点型
            float f = 0.12345678f;//(8位有效数字)(句尾要加f)
            double d = 0.12345678901234567;//(17位有效数字)
            decimal de = 0.12345678901234567890123456789012345678m;//(28位有效数字)
            //特殊
            char c = '我';//单字符
            string st = "你我他";//字符串
            bool b = true;//判断型(true/false)

            #endregion
            #region 常量
            const int changLiang = 1;//(在前加const表示常量,1必须初始化 2后续无法修改)
            #endregion

        }
    }
}
