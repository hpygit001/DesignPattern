using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂.Simple
{
    /// <summary>
    /// 抽象的四则运算基类
    /// </summary>
    public abstract class OperationBase
    {
        /// <summary>
        /// 输入参数1
        /// </summary>
        public double NumberA { get; set; }

        /// <summary>
        /// 输入参数2
        /// </summary>
        public double NumberB { get; set; }

        /// <summary>
        /// 获取运算的结果
        /// </summary>
        /// <returns></returns>
        public abstract double GetResult();

    }
}
