using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.桥接模式.Simple
{
    class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            Console.Write("M品牌：");
            soft.Run();
        }
    }
}
