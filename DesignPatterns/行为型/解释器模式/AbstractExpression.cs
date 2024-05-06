using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.解释器模式
{
    /// <summary>
    /// 抽象表达式，声明一个抽象地解释操作，这个接口为抽象语法树中的所有的节点所共享。
    /// </summary>
    abstract class AbstractExpression
    {
        public abstract void InterpretContext(Content content);
    }
}
