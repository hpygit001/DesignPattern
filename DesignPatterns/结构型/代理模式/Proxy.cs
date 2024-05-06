using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.代理模式
{
    class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            if(realSubject==null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }
}
