using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Block
{
    void Datalnit()
    {
        string[][] ST = 
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" }
        };
        string[][] SR =
        {
            new string[] { "■", "■", "■", "■" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        string[][] SB =
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" }
        };
        string[][] SL =
        {
            new string[] { "■", "■", "■", "■" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };

        string[][] TT =
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        string[][] TR =
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        string[][] TB =
        {
            new string[] { "□", "□", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        string[][] TL =
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
    }
}
