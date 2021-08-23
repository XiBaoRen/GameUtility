using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility.GameValue
{
    class Cabinet:IGameValue
    {
        #region 静态属性
        public const string default_name = "未命名柜子";
        #endregion

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
        public Dictionary<string, IGameValue> _dynamic_properties;
        private string _name;
        #endregion

        #region 成员函数声明及实现
        public Cabinet()
        {
            _name = default_name;
            _dynamic_properties = new Dictionary<string, IGameValue>();
        }

        public StringBuilder Individual
        #endregion
    }
}
