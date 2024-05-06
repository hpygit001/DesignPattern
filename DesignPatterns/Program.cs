using DesignPatterns.创建型;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {

        static Action action;
        static void Main(string[] args)
        {

            #region 创建型模式测试
            ////测试简单工厂模式
            //ProductTest.Test();

            //测试工厂方法
            // 创建型.工厂方法.ProductTest.Test();

            //抽象工厂模式：
            // DesignPatterns.创建型.抽象工厂.AbstractFactoryTest.Test();

            //建造者模式
            //DesignPatterns.创建型.建造者模式.BuilderTest.Test();


            //原型模式
            //DesignPatterns.创建型.原型模式.TestICloneable.Test();

            #endregion

            #region 结构型设计模式

            //适配器模式
            //DesignPatterns.结构型.适配器模式.TestAdapter.Test();


            //桥接模式
            //DesignPatterns.结构型.桥接模式.BridgeTest.Test();

            //组合设计模式
            //DesignPatterns.结构型.组合模式.ComponentTest.Test();

            //装饰模式
            //DesignPatterns.结构型.装饰模式.DecoratorTest.Test();

            //外观模式
            //DesignPatterns.结构型.外观模式.FacadeTest.Test();


            //享元模式
            //DesignPatterns.结构型.享元模式.FlyweightTest.Test();

            //代理模式
            //DesignPatterns.结构型.代理模式.ProxyTest.Test();
            #endregion
            #region 行为型

            //DesignPatterns.行为型.职责链模式.ChainOfResponsibilityTest.Test();

            //DesignPatterns.行为型.命令模式.CommandTest.Test();

            //DesignPatterns.行为型.解释器模式.InterpreterTest.Test();
            //DesignPatterns.行为型.中介者模式.MediatorTest.Test();

            //DesignPatterns.行为型.备忘录模式.MementoTest.Test();

            //DesignPatterns.行为型.状态模式.StateTest.Test();

            //DesignPatterns.行为型.策略模式.ContextTest.Test();

            //DesignPatterns.行为型.模板方法模式.TempleteMethodTest.Test();


            DesignPatterns.行为型.访问者模式.VisitorTest.Test();
                #endregion



            Console.ReadKey();

        }
    }
}
