using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;

namespace bosh
{
    /*
    struct Player()
    {
        public int hp;
        public int atk;
    }

    struct Monster()
    {
        public int hp;
        public int atk;
    }
    class Program
    {
        enum ClassType
        {
            None,
            Knight,
            Mage,
            Rogue
        }

        enum MonsterType
        { 
            None,
            Slime,
            Skletone,
            Orc,
            YourMother
        }

        static ClassType ClassChoice()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 마법사");
            Console.WriteLine("[3] 도둑");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Mage;
                    break;
                case "3":
                    choice = ClassType.Rogue;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            
            switch (choice) 
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.atk = 10;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.atk = 15;
                    break;
                case ClassType.Rogue:
                    player.hp = 75;
                    player.atk = 12;
                    break;
                default:
                    player.hp = 0;
                    player.atk = 0;
                    break;
            }
            // 기사(100/10), 마법사(50/15), 도둑(75/12)
        }

        static void CreateMonster(MonsterType type,out Monster monster)
        {
            Random mob = new Random();
            MonsterType radom = (MonsterType)mob.Next(1, 5);
            switch (radom)
                {
                case MonsterType.Slime:
                    monster.hp = 20;
                    monster.atk = 2;
                    break;

                case MonsterType.Skletone:
                    monster.hp = 40;
                    monster.atk = 4;
                    break;

                case MonsterType.Orc:
                    monster.hp = 30;
                    monster.atk = 3;
                    break;

                case MonsterType.YourMother:
                    monster.hp = 99999;
                    monster.atk = 99999;
                    break;
                default :
                    monster.hp = 0;
                    monster.atk = 0;
                    break;
            }
            Console.WriteLine($"{monster.hp},{monster.atk}");

        }

        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;
            MonsterType monster = MonsterType.None;

            Player player ;
            Monster monsterrand ;

            while (true)
            {
                choice = ClassChoice();
                

                if (choice != ClassType.None)
                {
                    // 캐릭터 생성
                   
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP {player.hp}, ATK {player.atk}");
                }
               
            }
        }
    }
}

*/

    /*
     class Wizard
     {
         int mp;
         int intell;
         public Wizard()
         {
             mp = 50;
             intell = 100;
         }

         static void Main()
         {
             Wizard wizard= new Wizard();
             Console.WriteLine($"mp:{wizard.mp},int:{wizard.intell}");
         }

     }
    */

    abstract class Animal
    {
        public Animal(string Name)
        {
        }
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public Dog(string Name) : base(Name)
        {
            Console.WriteLine($"안녕하세요 저는{Name}입니다");
        }

        public override void MakeSound()
        {
            Console.WriteLine("멍멍~");

        }
    }
    class Cat : Animal
    {
        public Cat(string Name) : base(Name)
        {
            Console.WriteLine($"안녕하세요 저는{Name}입니다");
        }
        public override void MakeSound()
        {
            Console.WriteLine("야옹~");

        }
    }
    class Cow : Animal
    {
        public Cow(string Name) : base(Name)
        {
            Console.WriteLine($"안녕하세요 저는{Name}입니다");
        }
        public override void MakeSound()
        {

            Console.WriteLine("음머~");
        }
    }
    public class FookingRazerSite
    {
        static void Main()
        {

            Animal dog = new Dog("dog");
            dog.MakeSound();

            Cat cat = new Cat("cat");
            cat.MakeSound();

            Cow cow = new Cow("cow");
            cow.MakeSound();

        }
    }
}