using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.组合模式
{

    /// <summary>
    /// Componet 为组合中的对象声明接口，在适当情况下，实现所有类共有接口的默认行为。声明一个
    /// 接口用于访问和管理Component的子部件。
    /// 
    /// </summary>
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);


    }
}
