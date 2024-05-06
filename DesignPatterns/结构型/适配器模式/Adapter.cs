using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.适配器模式
{
    class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();


        public override void Request()
        {
            adaptee.SpecificRequest();
        }

    }
}
