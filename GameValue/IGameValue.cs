using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility.GameValue
{
    interface IGameValue:IGamePath<IGameValue>
    {
        public string name { get; set; }
        public bool is_cabinet { get; }
    }
}
