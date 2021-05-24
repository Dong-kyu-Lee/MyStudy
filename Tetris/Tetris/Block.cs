using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOCKDIR
{
    T,
    R,
    B,
    L
}

enum BLOCKTYPE
{
    BT_I, //짝대기
    BT_L, //오른쪽 갈고리
    BT_J, //왼쪽 갈고리
    BT_Z, //번개모양
    BT_S, //번개모양
    BT_T, //T모양
    BT_O  //네모
}

partial class Block
{
    int X = 0;
    int Y = 0;
    List<List<BK>> BlockData = new List<List<BK>>();

    TetrisScreen Screen = null;
    
    public Block(TetrisScreen _screen)
    {
        Screen = _screen;

        for(int y = 0; y < 4; ++y)
        {
            BlockData.Add(new List<BK>());
            for(int x = 0; x < 4; x++)
            {
                BlockData[y].Add(BK.V);
            }
        }
    }

    private void Input()
    {
        if (false == Console.KeyAvailable)
        {
            return;
        }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.A:
                X -= 1;
                break;
                case ConsoleKey.D:
                X += 1;
                break;
                case ConsoleKey.S:
                Y += 1;
                break;
                default:
                break;
            }
    }

    public void Move()
    {
        Input();
        Screen.SetBlock(Y, X, "■");
    }
}
