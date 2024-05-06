using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.工厂方法.Simple
{
    /// <summary>
    /// 抽象运算的基类
    /// </summary>
    public abstract class OperationBase
    {
        /// <summary>
        /// 运算数1
        /// </summary>
        public double NumberA { get; set; }
        /// <summary>
        /// 运算数2
        /// </summary>
        public double NumberB { get; set; }

        /// <summary>
        /// 获取运算结果
        /// </summary>
        public abstract double GetResult();

    }
}
