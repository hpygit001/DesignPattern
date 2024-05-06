using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂.Simple
{
    class OperationFactory
    {

        public static OperationBase CreateOperation(string operation)
        {
            if (string.IsNullOrEmpty(operation)) throw new Exception("传入参数不能为空或null");
            switch(operation)
            {
                case "+":
                    return new OperationAdd();
                case "-":
                    return new OperationSub();
                case "*":
                    return new OperationMul();
                case "/":
                    return new OperationDiv();
                default:
                    throw new Exception($"输入参数错误，不存在参数为：{operation} 的操作运算！");
            }
        }
    }
}
