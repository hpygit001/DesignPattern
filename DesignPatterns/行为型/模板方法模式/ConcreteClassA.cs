using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.模板方法模式
{
    /// <summary>
    /// 实现父类定义的一个或多个抽象方法。每一个AbstractClass 都可以有任意多个ConcreteClass与之对应，
    /// 而每一个ConcreteClass 都可以给出这些抽象方法的不同实现，从而使得顶级逻辑的实现各不相同
    /// </summary>
    class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类A方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体A方法2实现");
        }
    }
}
