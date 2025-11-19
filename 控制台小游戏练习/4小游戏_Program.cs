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
                    case 1://开始场景
                        #region 开始场景
                        Console.Clear();
                        Console.SetCursorPosition(x / 2 - 6, 8);//设置光标位置
                        Console.Write("勇者营救公主");
                        int nowChoose = 1;//选择编号
                        while (true)
                        {
                            bool breakoff = false;
                            Console.SetCursorPosition(x / 2 - 4, 13);
                            Console.ForegroundColor = nowChoose == 1 ? ConsoleColor.Red : ConsoleColor.White;//三目运算符 判断选择
                            Console.Write("开始游戏");

                            Console.SetCursorPosition(x / 2 - 4, 15);
                            Console.ForegroundColor = nowChoose == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            char input = Console.ReadKey(true).KeyChar;//监听输入
                            switch (input)
                            {
                                case 'w':
                                case 'W':
                                    nowChoose++;
                                    if (nowChoose > 1)
                                    {
                                        nowChoose = 1;
                                    }
                                    break;
                                case 's':
                                case 'S':
                                    nowChoose--;
                                    if (nowChoose < 0)
                                    {
                                        nowChoose = 0;
                                    }
                                    break;
                                case ' '://确认: 空格键
                                    switch (nowChoose)
                                    {
                                        case 1:
                                            nowscene_ID = 2;
                                            breakoff = true;
                                            break;
                                        case 0:
                                            Environment.Exit(0);
                                            break;
                                    }
                                    break;
                            }
                            if (breakoff)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                    case 2://游戏场景
                        Console.WriteLine("游戏场景");
                        break;
                    case 3://结束场景
                        Console.WriteLine("结束场景");
                        break;
                }
            }
            #endregion
        }
    }
}
