using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式
{
    /// <summary>
    /// ConcreteVisitor1和ConcreteVisitor2 类，具体访问者，实现每个由Visitor 声明的操作。每个操作
    /// 实现算法的一部分，而该算法片段乃是对应于结构中对象的类。
    /// </summary>
    class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} 被{1} 访问",concreteElementA.GetType().Name,this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} 被{1} 访问", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
