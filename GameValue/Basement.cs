using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace GameUtility.GameValue
{
    class Basement<T>:IGameValue
    {
        #region 索引器声明及实现

        #region IGameValue接口需要实现的
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = name;
            }
        }

        public bool is_cabinet { get { return false; } }

        public IGameValue this[string path]
        {
            get
            {
                return GamePath<IGameValue>.PathResolve(this, path);
            }
        }

        public IGameValue this[string[] object_names, int pos]
        {
            get
            {
#if DEBUG
                StringBuilder builder = new StringBuilder();
                foreach (string object_name in object_names)
                {
                    builder.Append(object_name).Append("->");
                }
                builder.Remove(builder.Length - 2, 2);
                Console.WriteLine(builder.ToString());
#endif

                return new Basement<int>();
            }
        }

        #endregion
        #endregion

        #region 成员变量声明
        public Type template_type = typeof(T);
        private string _name;
        #endregion
    }
}
