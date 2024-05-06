using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.职责链模式
{
    class ChainOfResponsibilityTest
    {

        public static void Test()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (var item in requests)
            {
                h1.HandleRequest(item);
            }


        }
    }
}
