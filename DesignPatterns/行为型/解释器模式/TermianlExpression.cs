using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.解释器模式
{
    class TermianlExpression : AbstractExpression
    {
        public override void InterpretContext(Content content)
        {
            Console.WriteLine("终端解释器");
        }
    }
}
