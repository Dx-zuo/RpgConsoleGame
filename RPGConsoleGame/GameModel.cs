using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    enum Move
    {
        up,
        back,
        left,
        right
    }
    
    class GameModel
    {
        public int mapX;
        /// <summary>
        /// 地图定位坐标点
        /// </summary>
        public int MapX {
            get { return mapX; }
            set { if (value < 0)
                {
                    mapX = 0;
                }
                else {
                    mapX = value;
                }
            }
        }
        public int mapy;
        /// <summary>
        /// 地图定位坐标点
        /// </summary>
        public int MapY
        {
            get { return mapy; }
            set
            {
                if (value < 0)
                {
                    mapy = 0;
                }
                else
                {
                    mapy = value;
                }
            }
        }
        string[] wuqi = new string[] { "屠龙宝刀", "倚天剑", "红烧狮子头" ,"大鸡腿"};
        string[] yaoping = new string[] { "小炒肉", "抹茶粟", "糖醋排骨","小龙坎" };
        string[] renwu = new string[] { "干掉10个怪", "干掉20个怪", "干掉boss", "找到神秘宝箱" };
        string[] jineng = new string[] { "庐山升龙霸", "十万伏特", "秒默全", "+1 S" };
        /// <summary>
        /// 初始化数据
        /// </summary>
        public void initData(int sizeX,int sizeY) {
            char[,] data = new char[sizeY, sizeX];
            for (int i = 1; i < data.GetLength(1); i++)
            {
                for (int x = 1; x < data.GetLength(1); x++)
                {
                    data[x, i] = ' ';
                }
            }
            ViewData.Viewsource = data;
        }
        //猪脚运动位移坐标计算
        public void CharacterMove(Pikachu character,Move move) {
            int x = character.characterX;
            int y = character.characterY;

            switch (move)
            {
                case Move.up:
                    character.characterY -= 1;
                    break;
                case Move.back:
                    character.characterY += 1;
                    break;
                case Move.left:
                    character.characterX -= 1;
                    break;
                case Move.right:
                    character.characterX += 1;
                    break;
            }
            //杂货商人
            if (ViewData.ViewResource[character.characterY, character.characterX] == '4')
            {
                character.characterY = y;
                character.characterX = x;
                //new GameView().Dialogue("技能导师", "——嘻~冒险者，还没吃？那快来我这儿买点吃的吧~");
                new GameView().Dialogue("技能导师", "——嘻~冒险者，想学习最技术嘛,屠龙宝刀点击就送!!!~");
                new GameView().message(jineng);
                return;
            }
            //武器商人
            if (ViewData.ViewResource[character.characterY, character.characterX] == 'w')
            {
                character.characterY = y;
                character.characterX = x;
                new GameView().Dialogue("武器商人", "哼~刀剑无眼,小心你的手！这可不是给小孩子玩的玩具！");
                new GameView().message(wuqi);
                return;
            }
            //药品商人
            if (ViewData.ViewResource[character.characterY, character.characterX] == 'y')
            {
                character.characterY = y;
                character.characterX = x;
                new GameView().Dialogue("药品商人", "Oh~可怜的孩子~你看起来虚弱极了~快过来买点药水吧~");
                new GameView().message(yaoping);

                return;
            }
            //NPC指引
            if (ViewData.ViewResource[character.characterY, character.characterX] == 'n')
            {
                character.characterY = y;
                character.characterX = x;
                new GameView().Dialogue("NPC指引", "勇敢的年轻人  欢迎来到蛋蛋村~~~~~~~~~~~");
                return;
            }
            //宝箱
            if (ViewData.ViewResource[character.characterY, character.characterX] == '6')
            {
                character.characterY = y;
                character.characterX = x;
                new GameView().Dialogue("商人", "勇敢的年轻人 我这儿啥都有   你想购买点什么呢?");
                return;
            }
            //任务
            if (ViewData.ViewResource[character.characterY, character.characterX] == '3')
            {
                character.characterY = y;
                character.characterX = x;
                new GameView().Dialogue("奥特曼", "你居然来到这里了 ~ 哈哈  我这边有点小事情想找你帮帮忙~");
                new GameView().message(renwu);
                return;
            }
            ///判断是否有npc
            if (ViewData.ViewResource[character.characterY, character.characterX] != '0')
            {
                character.characterY = y;
                character.characterX = x;
                return;
            }
            ///
            //if (character.characterY < 2 || character.characterY > 17)
            //{
            //    character.characterY = y;
            //    return;
            //}
            //else if (character.characterX < 2 || character.characterX > 35)
            //{
            //    character.characterX = x;
            //    return;
            //}
        }
        /// <summary>
        /// 展示地图计算
        /// </summary>
        /// <param name="move"></param>
        /// <param name="sizex"></param>
        /// <param name="sizey"></param>
        public void MapMove(Move move,int sizex,int sizey) {
            if (sizex< 0 || sizey <0)
            {
                return;
            }
            var data = ViewData.ViewResource;
            var dataxp = ViewData.Viewsource;
            for (int y = 0; y < dataxp.GetLength(0); y++)
            {
                for (int x = 0; x < dataxp.GetLength(1); x++)
                {
                    ViewData.Viewsource[y, x] = data[y+ sizey,x+ sizex];
                }
            }
        }
        /// <summary>
        /// 添加怪物
        /// </summary>
        /// <param name="character"></param>
        public void AddBoss(Character character) {
            Console.Write(" {0}.{1} {2} ", character.characterX, character.characterY, character.tag);
            ViewData.ViewResource[character.characterY, character.characterX] = character.tag;
            ViewData.ViewResource[character.characterY, character.characterX+1] = 'b';
        }
        public void ClearBoss(Character character) {
            ViewData.ViewResource[character.characterY, character.characterX] = '0';
            ViewData.ViewResource[character.characterY, character.characterX + 1] = '0';
        }
        public void Addporp(char tag,int x,int y) {
            ViewData.ViewResource[x, y] = tag;
            ViewData.ViewResource[x, y] = 'b';
        }
    }
}
