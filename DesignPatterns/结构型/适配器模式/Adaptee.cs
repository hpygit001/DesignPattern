using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.适配器模式
{
    class Adaptee
    {

        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求！");
        }

    }
}
