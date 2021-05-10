using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum STARTSELECT
{
    TOWN = 1, BATTLE, NOWHERE
}

namespace Game
{
 
    class Player
    {
        private int AT = 100;
        private int HP = 500;
        private int maxHP = 1000;

        public void HealHP()
        {
            if(HP < maxHP)
            {
                HP += 10;
            }
        }
        public void playerStatus()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("공격력: " + AT);
            Console.WriteLine("체력: " + HP + "/" + maxHP);
            Console.WriteLine("-------------------------");
        }
    }

    class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.WriteLine("1. 마을    2. 배틀");
            Console.WriteLine("어디로 이동하시겠습니까?");
            Console.WriteLine("-------------------------");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch(keyInfo.Key)
            {
                case ConsoleKey.D1:
                    return STARTSELECT.TOWN;
                case ConsoleKey.D2:
                    return STARTSELECT.BATTLE;
                default:
                    return STARTSELECT.NOWHERE;
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();

            while(true)
            {
                StartSelect();
            }
        }
        
    }
}
