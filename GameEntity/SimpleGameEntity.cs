using GameUtility.GameValue;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility.GameEntity
{
    class SimpleGameEntity
    {
        public IGameValue this[string path]
        {
            get
            {
                path.Split('/','\\');
            }
        }

        public IGameValue this[string[] object_names]
        {
            get
            {

            }
        }
        private Dictionary<string, IGameValue> dynamic_properties;

    }
}
