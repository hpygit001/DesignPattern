using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.策略模式
{
    class ConcreteStrategyB : Strategy
    {
        /// <summary>
        /// 算法B实现
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
}
