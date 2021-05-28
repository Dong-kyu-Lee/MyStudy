using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOCKDIR
{
    BD_T,
    BD_R,
    BD_B,
    BD_L,
    BD_MAX
}

enum BLOCKTYPE
{
    BT_I, //짝대기
    BT_L, //오른쪽 갈고리
    BT_J, //왼쪽 갈고리
    BT_Z, //번개모양
    BT_S, //번개모양
    BT_T, //T모양
    BT_O,  //네모
    BT_MAX
}

partial class Block
{
    int X = 0;
    int Y = 0;
    BLOCKDIR Dir = BLOCKDIR.BD_T; // 회전 기능
    string[][] Arr = null;
    //List<List<BK>> BlockData = new List<List<BK>>();

    TetrisScreen Screen = null;

    public Block(TetrisScreen _screen)
    {
        Screen = _screen;
        Datalnit();

        SettingBlock(BLOCKTYPE.BT_T, BLOCKDIR.BD_R);
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
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
        
        for(int y = 0; y < 4; ++y)
        {
            for(int x= 0; x < 4; ++x)
            {
                if (Arr[y][x] == "□")
                    continue;
                Screen.SetBlock(Y + y, X + x, Arr[y][x]);
            }
        }
    }
}
