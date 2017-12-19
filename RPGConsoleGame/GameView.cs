using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    class GameView
    {
        public int pkx;
        public int pky;
        /// <summary>  
        /// 画面更新速率  
        /// </summary>  
        private Int32 m_updateRate;
        /// <summary>  
        /// 当前帧数  
        /// </summary>  
        private Int32 m_fps;
        /// <summary>  
        /// 记录帧数  
        /// </summary>  
        private Int32 m_tickcount;
        /// <summary>  
        /// 记录上次运行时间  
        /// </summary>  
        private Int32 m_lastTime;
        /// <summary>  
        /// 游戏是否结束  
        /// </summary>  
        private Boolean m_bGameOver;
        
        public int sizeX;
        public int sizeY;
        /// <summary>
        /// 边框量
        /// </summary>
        public int sizeLeft;
        public void ViewPlayer() {
            Console.SetWindowSize(sizeX, sizeY);
            sizeLeft = 3;

            //sizeX = Console.WindowWidth;
            //sizeY = Console.WindowHeight;
            //                    if ((x > sizeLeft && x < sizeX /3) && (y > sizeLeft && y < sizeY - sizeLeft*3))
            //Console.Write(sizeX / 3 - sizeLeft);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write((sizeY - sizeLeft * 3) - sizeLeft);
            
            RefreshView();
            Dialogue("喜洋洋", "别看我只是一只羊 羊儿的聪明难以想象 ");
            Attribute(default(Character));

            //Console.SetCursorPosition(3, 11);
            //Console.Write("9999999999999999999");
        }
        void RefreshView() {
            for (int y  = 0; y < sizeY-8; y++)
            {
                for (int x = 0; x < sizeX/2; x++)
                {
                    if (y ==2 && x == 4)
                    {
                        //Console.MoveBufferArea
                        //.Write("勇士: xxxxx 对话");
                        //Console.Write("  ");
                        //Console.Write("血量: 无敌的");
                        //Console.Write("  ");
                        //Console.Write("防御: 无敌的");

                    }
                    if ((x > sizeLeft && x < sizeX /3) && (y > sizeLeft && y < sizeY - sizeLeft*3))
                    {
                        ///游戏视图
                        if (x == sizeLeft + 1 || x == sizeX / 3 - 1)
                        {
                            ///列数 X轴
                            Console.Write('▓');

                        } else if (y == sizeLeft + 1 || y == sizeY - sizeLeft * 3-1) {
                            ///行数 y轴
                            Console.Write("=");
                        }
                        else {
                            Console.Write("1");
                        }
                        //Console.Write(" ");
                    }
                    else if (x > sizeX / 3 && y > sizeLeft &&y < sizeY - sizeLeft * 3)
                    {
                        if (y < sizeY / 3-1)
                        {
                            if (y == sizeY / 3 - 2 || y == sizeLeft + 1)
                            {
                                Console.Write("-");
                            }
                            if (x == sizeX / 3 + 1)
                            {
                                Console.Write("|");
                            }
                            else {
                                //Console.Write(" {0}.{1} ",y,x);
                            }
                        }
                        //if (x == sizeX / 3 + 1) {
                        //    int lef = sizeY / 3;
                        //    if (y == lef)
                        //    {
                        //        Console.Write("生命: ★★★");
                        //    }
                        //    if (y == lef+2)
                        //    {
                        //        Console.Write("角色: 皮卡丘");
                        //    }
                        //    if (y == lef+4)
                        //    {
                        //        Console.Write("血量: 无敌的");
                        //    }
                        //    if (y == lef+6)
                        //    {
                        //        Console.Write("魔法: 用不完的");
                        //    }
                        //    if (y == lef + 8)
                        //    {
                        //        Console.Write("拥有技能 : 鸡腿 蘑菇");
                        //    }
                        //    if (y == lef+11)
                        //    {
                        //        Console.Write("拥有物品 : 电击  雷击 灰机");
                        //    }
                        //}
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 游戏对话
        /// </summary>
        /// <param name="dialogue"></param>
        public void Dialogue(string name, string Dialogue) {
            Console.SetCursorPosition(4, 2);
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0} :",name);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Dialogue);
        }
        /// <summary>
        /// 角色属性
        /// </summary>
        /// <param name="character"></param>
        void Attribute(Character character) {
            //if (x == sizeX / 3 + 1)
            //{
            //    int lef = sizeY / 3;
            //    if (y == lef)
            Console.SetCursorPosition(sizeX / 3 + 3, sizeY / 3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("生命: ★★★");
            Console.SetCursorPosition(sizeX / 3 + 3, sizeY / 3+2);
            Console.Write("角色: 皮卡丘");
            Console.SetCursorPosition(sizeX / 3 + 3, sizeY / 3+4);
            Console.Write("血量: ■■■■■■■■■■");
            Console.SetCursorPosition(sizeX / 3 + 3, sizeY / 3 + 6);
            Console.Write("魔法: ■■■■■■■■■■");
            Console.SetCursorPosition(sizeX / 3 + 3, sizeY / 3 + 8);
            Console.Write("拥有技能 : 鸡腿 蘑菇");
            Console.SetCursorPosition(sizeX / 3 + 3, sizeY / 3 + 10);
            Console.Write("拥有物品 : 电击  雷击 灰机");

        }
        /// <summary>
        /// Npc属性
        /// </summary>
        /// <param name="character"></param>
        void NpcAttribute(Character character) {
            Console.SetCursorPosition(sizeX / 3 + 3, sizeY / 3);

        }
        /// <summary>
        /// 绘制游戏视图
        /// </summary>
        /// <param name="gameview"></param>
        /// <param name="y"></param>
        /// <param name="x"></param>
        public void RefreshGameView(char[,] gameview,int y,int x,int characterx ,int charactery) {
            Console.ForegroundColor = ConsoleColor.Red;
            var data = ViewData.ViewResource;
            //Console.Write(sizeX / 3 - sizeLeft);
            //Console.Write((sizeY - sizeLeft * 3) - sizeLeft);



            int gamex = sizeX / 3 - sizeLeft-3;
            int gamey = (sizeY - sizeLeft * 3) - sizeLeft-3;
            for (int yi = 0; yi < gamey; yi++)
            {
                Console.SetCursorPosition(sizeLeft+3, sizeLeft+2+ yi);
                for (int xi = 0; xi < gamex; xi++)
                {

                    if (y + yi == charactery && x + xi == characterx)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        pkx = Console.CursorLeft;
                        pky = Console.CursorTop;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    //空地
                    else if (data[y + yi, x + xi] == '0')
                    {
                        Console.Write(" ");
                        //Console.Write(gameview[y + yi, x + xi]);
                    }
                    //墙壁
                    else if (data[y + yi, x + xi] == '1')
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    //房子
                    else if (data[y + yi, x + xi] == '2')
                    {
                        //Console.Write("^");
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (data[y + yi, x + xi] == '3')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("N");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    //技能商人
                    else if (data[y + yi, x + xi] == '4')
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Q");
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    //草地
                    else if (data[y + yi, x + xi] == '5')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(";");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    //宝箱
                    else if (data[y + yi, x + xi] == '6')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("8");
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    //武器
                    else if (data[y + yi, x + xi] == 'w')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("W");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    //药品
                    else if (data[y + yi, x + xi] == 'y')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Y");
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else if (data[y + yi, x + xi] == 'n')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("N");
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else if (data[y + yi, x + xi] == 's')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("!");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (data[y + yi, x + xi] == '6')
                    {
                        Console.Write("&");
                    }
                    //怪物 由于怪物符合占两个空位  所以& 输出符合 b输出空白
                    else if (data[y + yi, x + xi] == '&')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("♀");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (data[y + yi, x + xi] == 'i')
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("a");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (data[y + yi, x + xi] == '$')
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("♀");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (data[y + yi, x + xi] == 'b')
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    else {
                        Console.Write(" ");
                    }
                }
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;

        }
        /// <summary>
        /// 购买选项框
        /// </summary>
        /// <param name="list"></param>
        public void message(string[] list) {
            Console.SetCursorPosition(4, 23);
            for (int i = 0; i < list.Length; i++)
            {
                //Console.BackgroundColor = ConsoleColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("{0}.{1} ",i+1,list[i]);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        /// <summary>
        /// 提示版
        /// </summary>
        /// <param name="tile"></param>
        public void Tooltip(int x,int y) {
            Console.SetCursorPosition(45, 5);

            Console.Write("{0},{1}",x,y);
            //Console.Write(tile);
        }
    }

}
