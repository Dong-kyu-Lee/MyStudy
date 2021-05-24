using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            TetrisScreen NewSC = new TetrisScreen(10,15);

            Block newBlock = new Block(NewSC);

            while(true)
            {
                for(int i = 0; i < 20000000; i++)
                {
                    int k = 0;
                }
                Console.Clear();
                NewSC.Render();
                NewSC.Clear();
                newBlock.Move();
            }
        }
    }
}
