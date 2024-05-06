using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式
{
    class StateTest
    {

        public static void Test()
        {
            //Context c = new Context(new ConcreteStateA());

            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            //=======================================================================

            Simple.Work emergencyPrijects = new Simple.Work();
            emergencyPrijects.Hour = 9;
            emergencyPrijects.WriteProgram();

            emergencyPrijects.Hour = 10;
            emergencyPrijects.WriteProgram();
            emergencyPrijects.Hour = 12;
            emergencyPrijects.WriteProgram();
            emergencyPrijects.Hour = 14;
            emergencyPrijects.WriteProgram();
            emergencyPrijects.Hour = 17;
            emergencyPrijects.WriteProgram();

            emergencyPrijects.TaskFinished = true;

            emergencyPrijects.WriteProgram();
            emergencyPrijects.Hour = 19;
            emergencyPrijects.WriteProgram();
            emergencyPrijects.Hour = 22;
            emergencyPrijects.WriteProgram();



        }
    }
}
