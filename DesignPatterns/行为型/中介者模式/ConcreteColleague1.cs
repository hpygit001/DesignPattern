using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.中介者模式
{
    class ConcreteColleague1:Colleague
    {
        public ConcreteColleague1(Mediator mediator):base(mediator)
        {

        }


        public void Send(string message)
        {
            mediator.Send(message, this);
        }


        public void Notify(string message)
        {
            Console.WriteLine("同事1得到信息："+message);
        }

    }
}
