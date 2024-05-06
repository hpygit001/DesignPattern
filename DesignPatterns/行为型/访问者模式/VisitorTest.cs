using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式
{
    class VisitorTest
    {

        public static void Test()
        {
            Simple.ObjectStructure o = new Simple.ObjectStructure();
            o.Attach(new Simple.Man());
            o.Attach(new Simple.Woman());

            //成功时的反应
            Simple.Success v1 = new Simple.Success();
            o.Display(v1);

            //失败时的反应
            Simple.Failing v2 = new Simple.Failing();
            o.Display(v2);

            //恋爱时的反应
            Simple.Amativeness v3 = new Simple.Amativeness();
            o.Display(v3);


        }
    }
}
