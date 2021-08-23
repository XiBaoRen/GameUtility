using GameUtility.GameValue;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameUtility.GameEntity
{
    class SimpleGameEntity:IGameEntity,IGamePath<IGameValue>
    {
        #region 静态属性
        public const string default_name= "未命名实体";
        #endregion


        #region 索引器声明及实现
        #region IGameEntity接口需要实现的
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        #endregion

        #region IGamePath<IGameValue>接口需要实现的
        public IGameValue this[string path]
        {
            get
            {
#if DEBUG
                Console.Write("尝试获取目标属性:");
#endif
                return GamePath<IGameValue>.PathResolve(this, path);
            }
        }

        public IGameValue this[string[] object_names, int pos]
        {
            get
            {
                if(_dynamic_properties.ContainsKey(object_names[pos]))
                {
                    if(pos+1==object_names.Length)
                    {
                        return _dynamic_properties[object_names[pos]];
                    }
                    else
                    {
                        return _dynamic_properties[object_names[pos]][object_names, pos + 1];
                    }
                }
                else
                {
                    throw new KeyNotFoundException(String.Format("找不到该实体的名为{0}的目标属性", object_names[pos]));
                }
            }
        }
        #endregion

        #endregion


        #region 成员变量声明
        public Dictionary<string, IGameValue> _dynamic_properties;
        public string _name;
        #endregion


        #region 成员函数声明及实现
        public SimpleGameEntity()
        {
            _name = default_name;
            _dynamic_properties = new Dictionary<string, IGameValue>();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("实体[").Append(_name).Append("]\n");

            int loop_counter = 0;
            int trav_depth = 0;
            foreach(string name in _dynamic_properties.Keys)
            {
                if(loop_counter==_dynamic_properties.Count-1)
                    builder.Append(GameOut.MiddleUnitBranch(name,trav_depth, true)).Append('\n');
                else
                    builder.Append(GameOut.MiddleUnitBranch(name, trav_depth)).Append('\n');
                loop_counter++;
            }
            return builder.ToString();
        }
        #endregion
    }
}
