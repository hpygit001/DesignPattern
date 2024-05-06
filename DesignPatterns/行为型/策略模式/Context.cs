using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.策略模式
{
    /// <summary>
    /// 上下文
    /// </summary>
    class Context
    {

        Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// 上下文接口
        /// </summary>
        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }

    }
}
