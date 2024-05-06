using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.工厂方法.Simple
{
    class FactorySub : IOperationFactory
    {
        public OperationBase CreateOperation()
        {
            return new OperationSub();
        }
    }
}
