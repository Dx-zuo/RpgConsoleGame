using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    public class Character
    {
        /// <summary>
        /// 级别
        /// </summary>
        int Level;
        public char tag;
        string name;
        /// <summary>
        /// 血量
        /// </summary>
        public float Hp;
        /// <summary>
        /// 法术
        /// </summary>
        float Mp;
        /// <summary>
        /// 伤害
        /// </summary>
        float Attack;
        /// <summary>
        /// 防御
        /// </summary>
        /// 
        float Defense;
        public int characterX;
        public int characterY;
        public Character(char tag,int Level, string name, float Hp, float Mp, float Attack, float Defense,int characterX,int characterY)
        {
            this.tag = tag;
            this.Hp = Hp;
            this.Level = Level;
            this.name = name;
            this.Mp = Mp;
            this.Attack = Attack;
            this.Defense = Defense;
            this.characterX = characterX;
            this.characterY = characterY;
        }
        public virtual void TakeAttack(float hurt) {
            Hp = Hp - hurt * (1 - (Defense / 100));
            if (Hp < 0)
            {
                Hp = 0;
            }
        }
        }
        /// <summary>
        /// 皮卡丘
        /// </summary>
        public class Pikachu : Character {
        /// <summary>
        /// 级别
        /// </summary>
        int Level;
        char tag = 'A';
        string name;
        /// <summary>
        /// 血量
        /// </summary>
        float Hp;
        /// <summary>
        /// 法术
        /// </summary>
        float Mp;
        /// <summary>
        /// 伤害
        /// </summary>
        float Attack;
        /// <summary>
        /// 防御
        /// </summary>
        float Defense;
        public int characterX;
        public int characterY;
        public Pikachu(char tag, int Level, string name, float Hp, float Mp, float Attack, float Defense, int characterX, int characterY):base(tag, Level, name, Hp, Mp, Attack, Defense, characterX, characterY)
        {
            this.tag = tag;
            this.Hp = Hp;
            this.Level = Level;
            this.name = name;
            this.Mp = Mp;
            this.Attack = Attack;
            this.Defense = Defense;
            this.characterX = characterX;
            this.characterY = characterY;
        }
        public override void TakeAttack(float hurt) {
            
            Hp = Hp - hurt * (1 - (Defense / 100));
            if (Hp<0)
            {
                Hp = 0;
            }
        }


    }
    /// <summary>
    /// 史莱姆
    /// </summary>
    public class Slime : Character {
        /// <summary>
        /// 级别
        /// </summary>
        int Level;
        char tag = '&';
        string name;
        /// <summary>
        /// 血量
        /// </summary>
        float Hp;
        /// <summary>
        /// 法术
        /// </summary>
        float Mp;
        /// <summary>
        /// 伤害
        /// </summary>
        float Attack;
        /// <summary>
        /// 防御
        /// </summary>
        /// 
        float Defense;
        int characterX;
        int characterY;
        public Slime(char tag, int Level, string name, float Hp, float Mp, float Attack, float Defense, int characterX, int characterY):base(tag, Level, name, Hp, Mp, Attack, Defense, characterX, characterY)
        {
            this.tag = tag;
            this.Hp = Hp;
            this.Level = Level;
            this.name = name;
            this.Mp = Mp;
            this.Attack = Attack;
            this.Defense = Defense;
            this.characterX = characterX;
            this.characterY = characterY;
        }
    }
    /// <summary>
    /// 岩石怪物
    /// </summary>
    public class RockMon: Character
    {
        /// <summary>
        /// 级别
        /// </summary>
        int Level;
        char tag = '&';
        string name;
        /// <summary>
        /// 血量
        /// </summary>
        float Hp;
        /// <summary>
        /// 法术
        /// </summary>
        float Mp;
        /// <summary>
        /// 伤害
        /// </summary>
        float Attack;
        /// <summary>
        /// 防御
        /// </summary>
        /// 
        float Defense;
        int characterX;
        int characterY;
        public RockMon(char tag, int Level, string name, float Hp, float Mp, float Attack, float Defense, int characterX, int characterY):base(tag, Level, name, Hp, Mp, Attack, Defense, characterX, characterY)
        {
            this.tag = tag;
            this.Hp = Hp;
            this.Level = Level;
            this.name = name;
            this.Mp = Mp;
            this.Attack = Attack;
            this.Defense = Defense;
            this.characterX = characterX;
            this.characterY = characterY;
        }
    }
    /// <summary>
    /// boss
    /// </summary>
    public class BossMon : Character
    {
        /// <summary>
        /// 级别
        /// </summary>
        int Level;
        char tag = 'b';

        string name;
        /// <summary>
        /// 血量
        /// </summary>
        float Hp;
        /// <summary>
        /// 法术
        /// </summary>
        float Mp;
        /// <summary>
        /// 伤害
        /// </summary>
        float Attack;
        /// <summary>
        /// 防御
        /// </summary>
        /// 
        float Defense;
        int characterX;
        int characterY;
        public BossMon(char tag, int Level, string name, float Hp, float Mp, float Attack, float Defense, int characterX, int characterY):base(tag, Level, name, Hp, Mp, Attack, Defense, characterX, characterY)
        {
            this.tag = tag;
            this.Hp = Hp;
            this.Level = Level;
            this.name = name;
            this.Mp = Mp;
            this.Attack = Attack;
            this.Defense = Defense;
            this.characterX = characterX;
            this.characterY = characterY;
        }
    }
}
