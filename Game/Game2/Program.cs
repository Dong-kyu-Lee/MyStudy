using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Someone
{
    protected int ATT;
    protected int HP;
    protected string Name;

    public void Damage(Someone someone)
    {
        if (someone.HP >= ATT)
        {
            someone.HP -= ATT;
        }
        else Console.WriteLine(someone.Name + " was Dead!\n");
    }

    public void Status()
    {
        Console.WriteLine(Name);
        Console.WriteLine("ATT " + ATT + "\n" + "HP: " + HP);
    }
}

class Player: Someone
{
    public Player()
    {
        ATT = 100;
        HP = 1000;
        Name = "Player";
    }
}

class Monster: Someone
{
    public Monster()
    {
        Name = "Monster";
        ATT = 50;
        HP = 1000;
    } 
}

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            Monster newMonster = new Monster();
            while(true)
            {
                Console.WriteLine("1. 한 턴 실행\t2. 종료");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    newPlayer.Damage(newMonster);
                    newMonster.Damage(newPlayer);

                    newPlayer.Status();
                    Console.WriteLine("\n");
                    newMonster.Status();
                    Console.WriteLine("\n===============================\n");
                }
                else break;
            }

            
        }
    }
}
