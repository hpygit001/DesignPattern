using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式
{
    class CommandTest
    {

        public static void Test()
        {
            //Simple.one.CommandTestOne.Test();


            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();

            i.SetCommand(c);
            i.ExecuteCommand();

        }
    }
}
