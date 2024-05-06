using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式
{
    /// <summary>
    /// 定义一个Accept操作，它以一个访问者为参数
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
