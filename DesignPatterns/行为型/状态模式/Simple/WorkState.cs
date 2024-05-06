using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式.Simple
{
    abstract class WorkState
    {
        public abstract void WriteProgram(Work w);
    }
}
