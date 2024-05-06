using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.桥接模式.Simple
{
    class HandsetAddressList : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机通讯录");
        }
    }
}
