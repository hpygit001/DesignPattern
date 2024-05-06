using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式.Simple
{
    class AfternoonState : WorkState
    {
        public override void WriteProgram(Work w)
        {
            if(w.Hour<17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力",w.Hour);
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}
