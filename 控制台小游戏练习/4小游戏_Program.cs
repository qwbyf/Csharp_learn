namespace 小游戏
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 需求分析
            //开始界面: 控制台显示和输入;字体变色;监听键盘(wasd等)切换选项(switch)
            //游戏界面: 控制台显示和输入;字体变色;监听键盘(wasd等)操控;边界控制;战斗(随机数,循环,if条件,)
            //结束界面: 控制台显示和输入;字体变色;监听键盘(wasd等)切换选项;
            //界面切换
            #endregion

            #region 设置控制台
            //清空界面
            Console.Clear();
            //隐藏光标
            Console.CursorVisible = false;
            //设置界面大小
            int x=50; int y=30;
            Console.SetWindowSize(x,y);
            Console.SetBufferSize(x,y);
            #endregion

            #region 界面切换
            int nowscene_ID = 1;//                  scene 场景
            while (true)
            {
                switch (nowscene_ID)
                {
                    //开始场景
                    case 1:
                        Console.Clear();
                        #region 开始场景
                        Console.SetCursorPosition(x / 2 - 6, 8);//设置光标位置
                        Console.Write("勇者营救公主");
                        int nowChoose = 1;//选择编号
                        //单独构建一个循环 专门用来处理开始场景相关的逻辑
                        while (true)
                        {
                            bool breakoff = false;/*用一个标识 来处理 想要在while循环内部的switch逻辑执行时 
                                                    希望退出外层while循环时,改变标识即可*/
                            //先设置光标位置再显示内容
                            //根据当前选择的编号 来决定 是否变色
                            Console.SetCursorPosition(x / 2 - 4, 13);
                            Console.ForegroundColor = nowChoose == 1 ? ConsoleColor.Red : ConsoleColor.White;//三目运算符 判断选择
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(x / 2 - 4, 15);
                            Console.ForegroundColor = nowChoose == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            #region  监听键盘输入 并且不显示输入内容
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                //向上
                                case 'w':
                                case 'W':
                                    nowChoose++;
                                    if (nowChoose > 1)
                                    {
                                        nowChoose = 1;
                                    }
                                    break;
                                //向下
                                case 's':
                                case 'S':
                                    nowChoose--;
                                    if (nowChoose < 0)
                                    {
                                        nowChoose = 0;
                                    }
                                    break;
                                //确认
                                case ' ': //空格键 
                                case '\r'://回车键
                                    switch (nowChoose)
                                    {
                                        case 1:
                                            nowscene_ID = 2;//改变ID 切换到游戏场景
                                            breakoff = true;//通过改变标识 来退出内层循环
                                            break;
                                        case 0:
                                            Environment.Exit(0);
                                            break;
                                    }
                                    break;                            
                            }
                            #endregion
                            if (breakoff)break;                            
                        }
                        #endregion
                        break;

                    //游戏场景
                    case 2:
                        Console.Clear();
                        #region 游戏场景
                        #region 一: 周围不变的红墙
                        Console.ForegroundColor = ConsoleColor.Red;
                        //上下
                        for (int x0 = 0; x0 < x; x0 += 2)
                        {
                            Console.SetCursorPosition(x0, 0);
                            Console.Write("■");
                            Console.SetCursorPosition(x0, y - 1);
                            Console.Write("■");
                            Console.SetCursorPosition(x0, y - 6);
                            Console.Write("■");
                        }
                        //左右
                        for (int y0 = 0; y0 < y; y0++)
                        {
                            Console.SetCursorPosition(0, y0);
                            Console.Write("■");
                            Console.SetCursorPosition(x - 2, y0);
                            Console.Write("■");
                        }
                        #endregion
                        #region 二: 设置boos属性
                        string boos = "■";
                        int boss_X = 24;
                        int boss_Y = 15;
                        Random r = new Random();//创建随机数对象
                        int bossHP = 100;
                        int bossATK = r.Next(7, 14);                        
                        #endregion
                        while (true)
                        {
                            //绘制boos (活着时才显示)
                            if (bossHP > 0)
                            {
                                Console.SetCursorPosition(boss_X, boss_Y);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(boos);
                            }                            
                        }
                        #endregion
                        break;

                    //结束场景
                    case 3:
                        Console.Clear();
                        
                        break;
                }
            }
            #endregion
        }
    }
}
