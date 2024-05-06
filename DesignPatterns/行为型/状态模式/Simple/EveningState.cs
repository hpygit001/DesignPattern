using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式.Simple
{
    class EveningState : WorkState
    {
        public override void WriteProgram(Work w)
        {
            if(w.TaskFinished)
            {
                w.SetState(new ResetState());
                w.WriteProgram();
            }
            else
            {
                if(w.Hour<21)
                {
                    Console.WriteLine("当前时间：{0} 点 加班哦，疲累之极",w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();

                }

            }
        }
    }
}
