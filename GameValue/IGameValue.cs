using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility.GameValue
{
    interface IGameValue
    {
        public IGameValue this[string path]
        {
            get
            {
                return this[path.Split('/', '\\')];
            }
        }

        public IGameValue this[string[] object_names]
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                foreach(string object_name in object_names)
                {
                    builder.Append(object_name).Append("->");
                }
                Console.WriteLine(builder.ToString());

                return new Basement<int>();
            }
        }
    }
}
