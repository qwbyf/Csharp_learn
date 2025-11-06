using Microsoft.Win32.SafeHandles;

namespace 控制台小项目
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 修改控制台相关
            Console.WriteLine("123456789");
            Console.Clear();//清空控制台

            Console.SetWindowSize(100, 50);//设置窗口大小                                Window窗口
            Console.SetBufferSize(100, 50);//设置缓冲区(画布)大小                         Buffer缓冲
            //注意: 窗口大小 <= 缓冲区大小 <= 控制台最大尺寸
            //得到缓冲区的宽和高: Console.BufferWidth\Console.BufferHeight


            //控制台方向: 0 ——— > X
            //           |  
            //           v
            //           Y


            Console.SetCursorPosition(5, 10);// (x,y)设置光标位置(从何处开始打印)          Cursor光标   Position位置
            //注意: 在视觉上 一格y等于两格x的长度

            //设置颜色
            Console.ForegroundColor = ConsoleColor.Red;//设置文字颜色                     Fore ground color 前景色
            Console.BackgroundColor = ConsoleColor.White;//设置背景色                     Back ground color 背景色
            //若想将整个打印区的背景色改变,则还需先清除原来的,即再写:Console.Clear();

            //光标显隐
            Console.CursorVisible = false;//true显\false隐                               Cursor光标   Visible可见的

            //控制台自动关闭(调试模式时不会关闭)
            Environment.Exit(0);//                                                       Environment环境    Exit退出电脑程序

            #endregion


        }
    }
}
