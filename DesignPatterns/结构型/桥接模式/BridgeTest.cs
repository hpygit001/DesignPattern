using DesignPatterns.结构型.桥接模式.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.桥接模式
{
    class BridgeTest
    {

        public static void Test()
        {
            Abstraction ab = new RefinedAbstraction();
            ab.SetImplementor(new ConcreteImplementorA());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementorB());
            ab.Operation();

            Console.WriteLine("=".PadRight(30, '='));

            HandsetBrand ab1;
            ab1 = new HandsetBrandN();

            ab1.SetHandsetSoft(new HandsetGame());
            ab1.Run();

            ab1 = new HandsetBrandM();

            ab1.SetHandsetSoft(new HandsetGame());
            ab1.Run();

            ab1.SetHandsetSoft(new HandsetAddressList());
            ab1.Run();

            
        }
    }
}
