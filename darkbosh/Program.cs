using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace darkbosh
{
    class Character
    {
        public string Name;
        public int HP;
        public int Atk;

        public Character()
        {
        }

        public Character(string name, int hP, int atk)
        {

        }
        public virtual void Attack(Character tarrget)
        {
           tarrget.HP = tarrget.HP - Atk;

        }
        public bool IsDead()
        {
            if (HP <= 0)
            {
                return true;
            }
            else return false;
        }

    }
    class Player : Character
    {
        public int Exp;
        public Player() { }

        public Player(string name, int hp, int atk)
        {
            Name = name;
            HP = hp;
            Atk = atk;
        }
        public void GainExp(int amount)
        {
            Exp += amount;
        }

    }

    class Monster : Character
    {


        public Random AllRandom = new Random();
        public Monster() { }

        public Monster(string name)
        {
            Name = name;
            HP = AllRandom.Next(21, 51);
            Atk = AllRandom.Next(1, 7);

        }
        public override void Attack(Character tarrget)
        {
            base.Attack(tarrget);
        }

    }

    internal class Darkbosh
    {
        public static bool Askcont()
         {
             Console.WriteLine("설마 이거만 잡고 게임 끄려고? 쫄보임?(y/n)");
              string Countinue = Console.ReadLine()!.ToLower();
             if (Countinue == "y")
             {
                 Console.WriteLine("새끼 테토남이네 ㅋㅋ");
                 return true;
             }
             else
             {
                 Console.WriteLine("쫄보쉨ㅋㅋㅋㅋ");
                 return false;
             }
         }

        static string RandomName()
        {
            string[] name = { "슬라임", "고블린", "늑대", "박쥐" };
            return name[new Random().Next(name.Length)];
        }

        static void Main()
        {


            Random AllRandom = new Random();
            Player player = new Player("너",99, AllRandom.Next(10, 20));
            bool Infinity = true;

            while (Infinity)
            {
                Monster monster = new Monster(RandomName());
                Console.WriteLine($"와!{monster.Name}! 아주 좋은 경험치 공급원이죠!");
                Console.WriteLine($"저녀석의 체력은 {monster.HP} 이정도!");

                while (!monster.IsDead() && !player.IsDead())
                {
                    Console.WriteLine($"너의 공격으로 {monster.Name}은 {player.Atk}의 피해를 입었다!");
                    player.Attack(monster);
                    Console.WriteLine($"남은 몬스터 체력 {monster.HP}");

                    if (monster.IsDead())
                    {
                        Console.WriteLine($"이겼다!");
                        Console.WriteLine($"아무튼 랜덤한 경험치 획득!");
                        player.GainExp(AllRandom.Next(1, 11));
                        Console.WriteLine($"현재 너의 hp는 {player.HP}");
                        Infinity = Askcont();

                        break;
                    }
                        monster.Attack(player);
                        Console.WriteLine($"{monster.Name}의 공격!");
                        Console.WriteLine($"{monster.Atk}의 피해를 입었다!");
                        Console.WriteLine($"현재 {player.Name}의 hp는 {player.HP}");

                }

                if (player.IsDead())
                {
                    Console.WriteLine("실화임? 이걸죽어? 진짜진짜마?");
                    return;
                    
                }

                

            }
        }
    }
}

    


