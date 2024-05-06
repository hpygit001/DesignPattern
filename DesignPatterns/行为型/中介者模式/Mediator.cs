using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.中介者模式
{
    /// <summary>
    /// 抽象的中介者类
    /// </summary>
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
