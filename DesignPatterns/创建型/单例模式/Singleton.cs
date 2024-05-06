using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.单例模式
{
    /// <summary>
    /// 单例设计模式(Singleton)：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
    /// </summary>
    class Singleton
    {
        static readonly object ob_lock = new object();
        static Singleton Cur = null;

        private Singleton()
        {

        }

        public static Singleton CreateInstance()
        {
            if(Cur==null)
            {
                lock(ob_lock)
                {
                    if(Cur==null)
                    {
                        Cur = new Singleton();
                    }
                }
            }

            return Cur;
        }

    }
}
