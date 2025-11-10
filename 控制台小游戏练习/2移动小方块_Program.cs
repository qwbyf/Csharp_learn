namespace 移动小方块
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region << 通过W,A,S,D键在控制台中控制一个黄色小方块上下左右移动,注意边界问题 >>
            //how: 1.修改控制台, 2.绘制小方块(打印), 3.监听键盘输入(readkey,while)
            //     4.根据输入移动小方块(实质:根据逻辑切换帧画面)(switch,if), 5.处理边界问题(不超出缓冲区)


            //隐藏光标
            Console.CursorVisible = false;
            //修改背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //修改字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;            

            //不停地输入w,a,s,d控制小方块移动(通过设置光标位置实现)
            int x = 0;
            int y = 0;
            while (true)
            {
                //设置光标位置,绘制小方块
                Console.SetCursorPosition(x, y);//注意: 视觉上 一格y等于两格x的长度,所以x移动的距离需为y的两倍                
                Console.Write("■");
                //监听输入
                char input = Console.ReadKey(true).KeyChar;//ReadKey()中填true则不会把输入的内容显示出来,填false则与不填一样
                //擦除上一次绘制的小方块(在该位置用空格替代)
                Console.SetCursorPosition(x, y);
                Console.Write("  ");//注意: 一个中文符号占两格,所以需要两个空格

                //处理边界问题(不超出缓冲区)    注意: y轴正方向是向下, 原点在小方块 ■ 左上角
                switch (input)
                {
                    case 'W':
                    case 'w':
                        y -= 1;
                        if (y < 0)
                        {
                            y = 0;
                        }
                        break;
                    case 'A':
                    case 'a':
                        x -= 2;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        y += 1;
                        if (y > Console.BufferHeight - 1)
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if (x > Console.BufferWidth - 2)
                        {
                            x = Console.BufferWidth - 2;
                        }
                        break;
                }
            }
            #endregion


        }
    }
}
