using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式
{

    /// <summary>
    /// 为该对象结构中ConcreteElement的每一个类声明一个Visit操作
    /// </summary>
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);

        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);

    }
}
