using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.适配器模式
{
    class TestAdapter
    {

        public static void Test()
        {
            Target target = new Adapter();

            target.Request();


        }
    }
}
