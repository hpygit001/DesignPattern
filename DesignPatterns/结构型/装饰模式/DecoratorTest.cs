using DesignPatterns.结构型.装饰模式.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.装饰模式
{
    class DecoratorTest
    {

        public static void Test()
        {
            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //d1.SetComponent(c);
            //d2.SetComponent(d1);

            //d2.Operation();


            Person xc = new Person("小菜");

            Console.WriteLine("\n第一种装扮：");
            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();

          
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show(xc);



        }
    }
}
