using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂.Simple
{
    class OperationMul : OperationBase
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}
