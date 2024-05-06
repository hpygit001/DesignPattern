using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.抽象工厂
{
    class AbstractFactoryTest
    {

        public static void Test()
        {
            AbstractFactory factory = new Simple.CreateFactory2();

            AbstractProductA productA = factory.CreateProductA();
            productA.Show();

            AbstractProductB productB = factory.CreateProductB();
            productB.Play();

        }
    }
}
