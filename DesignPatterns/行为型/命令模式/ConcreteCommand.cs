using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式
{
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver):base(receiver)
        {

        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
