using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.桥接模式
{
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法执行");
        }
    }
}
