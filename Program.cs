using GameUtility.GameEntity;
using GameUtility.GameValue;
using System;
using System.IO;

namespace GameUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGameEntity se = new SimpleGameEntity();
            //Console.WriteLine(se["health"]);
            se._dynamic_properties.Add("核心", new Basement<int>());
            se._dynamic_properties.Add("护甲", new Basement<int>());
            Console.WriteLine(se["核心"]);
            Console.WriteLine(se);
        }
    }
}
