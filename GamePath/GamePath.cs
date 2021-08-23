using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility
{
    class GamePath<T>
    {
        public static char[] devide_char_array= {'/', '\\', '.'};
        public static T PathResolve(IGamePath<T> obj,string path)
        {
            return obj[path.Split(devide_char_array), 0];
        }
    }
}
