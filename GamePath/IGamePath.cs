using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility
{
    interface IGamePath<T>
    {
        public T this[string path]
        {get;}

        public T this[string[] object_names, int pos]
        {get;}
    }
}
