using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.模板方法模式
{
    class TempleteMethodTest
    {

        public static void Test()
        {
            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();


            c = new ConcreteClassB();
            c.TemplateMethod();
        }
    }
}
