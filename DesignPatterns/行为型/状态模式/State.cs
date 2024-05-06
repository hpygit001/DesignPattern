using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式
{
    abstract class State
    {

        public abstract void Handle(Context context);

    }
}
