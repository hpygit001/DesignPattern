using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂.Simple
{
    /// <summary>
    /// 加法运算
    /// </summary>
    class OperationAdd : OperationBase
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
