using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式
{
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求!");
        }
    }
}
