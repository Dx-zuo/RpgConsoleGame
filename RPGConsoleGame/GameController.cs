using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace RPGConsoleGame
{
    class GameController
    {
        GameModel model = new GameModel();
        GameView run = new GameView();
        Move orientation = Move.up;
        Pikachu pk;

        public void Run() {
            model.initData(51, 51);
            model.MapX = 3;
            model.MapY = 11;
            //添加猪脚
            pk = new Pikachu('Y',1, "皮卡丘", 111.1f, 51.1f, 11.1f, 51.1f, 29, 12);
            //添加怪物

            var sl = new Slime('&', 1, "史莱姆大哥", 111.1f, 51.1f, 11.1f, 51.1f, 15, 32);

            var sl2 = new Slime('&', 1, "史莱姆的父亲", 111.1f, 51.1f, 11.1f, 51.1f, 15, 34);
            model.AddBoss(sl);
            model.AddBoss(sl2);
            var rock = new RockMon('$', 1, "岩石聚聚", 111.1f, 51.1f, 11.1f, 51.1f, 9, 5);
            var rock1 = new RockMon('$', 1, "岩石爸爸", 111.1f, 51.1f, 11.1f, 51.1f, 18, 21);
            var rock2 = new RockMon('$', 1, "岩石妈妈", 111.1f, 51.1f, 11.1f, 51.1f, 15, 34);
            var rock3 = new RockMon('$', 1, "岩石奶奶", 111.1f, 51.1f, 11.1f, 51.1f, 15, 34);
            model.AddBoss(rock);
            model.AddBoss(rock1);
            model.AddBoss(rock2);
            model.AddBoss(rock3);
            ///❀boss
            model.Addporp('i',39,36);
            //添加门
            //model.Addporp('i',39,36);
            //model.Addporp('i',39,37);
            //model.Addporp('i',39,38);

            run.sizeX = 121;
            run.sizeY = 31;
            run.ViewPlayer();


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            model.MapX -= 1;
                            break;
                        case ConsoleKey.DownArrow:
                            model.MapX += 1;
                            break;
                        case ConsoleKey.LeftArrow:
                            model.MapY -= 1;
                            break;
                        case ConsoleKey.RightArrow:
                            model.MapY += 1;
                            break;
                        case ConsoleKey.W:
                            model.MapX -= 1;
                            orientation = Move.up;
                            model.CharacterMove(pk, Move.up);
                            break;
                        case ConsoleKey.S:
                            model.MapX += 1;
                            orientation = Move.back;
                            model.CharacterMove(pk, Move.back);
                            break;
                        case ConsoleKey.A:
                            model.MapY -= 1;
                            orientation = Move.left;
                            model.CharacterMove(pk, Move.left);
                            break;
                        case ConsoleKey.D:
                            model.MapY += 1;
                            orientation = Move.right;
                            model.CharacterMove(pk, Move.right);
                            break;
                        case ConsoleKey.Spacebar:
                            AttackAnimation(orientation,pk);
                            break;
                        default:
                            break;
                    }
                }
                //model.MapMove(Move.up, model.MapX, model.Mapy);
                //Thread.Sleep(211);
                run.Tooltip(pk.characterX, pk.characterY);
                run.RefreshGameView(ViewData.Viewsource, model.MapX, model.MapY, pk.characterX, pk.characterY);
            }
        }
        void move(Move move) {
            switch (move)
            {
                case Move.up:
                    break;
                case Move.back:
                    break;
                case Move.left:
                    break;
                case Move.right:
                    break;
            }
        }
        /// <summary>
        /// 猪脚攻击怪物
        /// </summary>
        /// <param name="hurt"></param>
        /// <param name="character"></param>
        void Attack(float hurt,Character character) {
            character.TakeAttack(hurt);
            if (character.Hp == 0)
            {
                model.ClearBoss(character);
            }
        }
        void AttackAnimation(Move move, Character character) {
            int x, y;
            x = run.pkx;
            y = run.pky;

            run.Tooltip(x, y);
            Thread.Sleep(50);
            int mapx = model.mapX;
            int mapy = model.MapY;


            //Console.Write("{0} {1} ",x,y);
            switch (move)
            {
                case Move.up:
                    Console.SetCursorPosition(x, y-1);
                    Console.Write("↑");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x-2, y-1);
                    Console.Write("↖");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x-2, y);
                    Console.Write('←');
                    Thread.Sleep(150);
                    break;
                case Move.back:
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("↓");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x + 2, y + 1);
                    Console.Write("↘");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x + 2, y);
                    Console.Write('→');
                    Thread.Sleep(150);
                    break;
                case Move.left:
                    Console.SetCursorPosition(x, y - 1);
                    Console.Write("↖");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x - 2, y - 1);
                    Console.Write("←");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x - 2, y);
                    Console.Write('↙');
                    Thread.Sleep(150);
                    break;
                case Move.right:
                    Console.SetCursorPosition(x+2, y-1);
                    Console.Write("↗");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x + 2, y);
                    Console.Write("→");
                    Thread.Sleep(150);
                    Console.SetCursorPosition(x, y+1);
                    Console.Write('↘');
                    Thread.Sleep(150);
                    break;
            }
            
        }
        void IsAttackBoos(int x, int y, float hurt) {

        }
    }
}
