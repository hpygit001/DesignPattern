using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.外观模式
{
    class FacadeTest
    {

        public static void Test()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

          
        }
    }
}
