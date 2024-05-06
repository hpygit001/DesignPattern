using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式.Simple
{
    class ResetState : WorkState
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点下班回家了",w.Hour);
        }
    }
}
