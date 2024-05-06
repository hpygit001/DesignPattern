using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.工厂方法.Simple
{
    /// <summary>
    /// 运算工厂创建对象的接口
    /// </summary>
    interface IOperationFactory
    {

        OperationBase CreateOperation();
    }
}
