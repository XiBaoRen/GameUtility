using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility
{
    class GameOut
    {
        public const string middle_connect_symbol = "├── ";
        public const string pass_connect_symbol = "│   ";
        public const string end_connect_symbol = "└── ";
        //public const string bar_symbol = "── ";
        public const string space_symbol = "  ";

        public static void Output(string str)
        {
#if VS
            Console.WriteLine(str);
#elif UNITY
            Debug.Log(str);
#endif
        }

        public static StringBuilder MiddleUnitBranch(string name,int depth,bool is_end=false)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(space_symbol);
            for(int i=0;i<depth;i++)
            {
                builder.Append(pass_connect_symbol);
            }
            if(is_end)
                builder.Append(end_connect_symbol).Append(name);
            else
                builder.Append(middle_connect_symbol).Append(name);
            return builder;
        }
    }
}
