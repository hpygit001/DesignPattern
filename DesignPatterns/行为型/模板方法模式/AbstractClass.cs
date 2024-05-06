using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.模板方法模式
{
    /// <summary>
    /// AbstractClass是抽象类，其实也就是一抽象模板，定义并实现了一个模板方法。这个模板方法一般
    /// 是一个具体方法，它给出了一个顶级逻辑的骨架，而逻辑的组成步骤在相应的抽象操作中，推迟到子类实现。
    /// 顶级逻辑也有可能调用一些具体的方法
    /// </summary>
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }

    }
}
