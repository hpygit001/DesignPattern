using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式.Simple
{
    class NoonState : WorkState
    {
        public override void WriteProgram(Work w)
        {
            if(w.Hour<13)
            {
                Console.WriteLine("当前时间：{0} 点饿了，午饭；犯困，午休。",w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}
