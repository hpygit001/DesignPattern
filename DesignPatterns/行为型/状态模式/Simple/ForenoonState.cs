using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式.Simple
{
    class ForenoonState : WorkState
    {
        public override void WriteProgram(Work w)
        {
            if(w.Hour<12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍",w.Hour);
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
}
