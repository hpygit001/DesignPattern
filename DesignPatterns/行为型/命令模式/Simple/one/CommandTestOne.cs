using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式.Simple.one
{
    class CommandTestOne
    {
        public static void Test()
        {
            Barbecuer boy = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);

            Waiter girl = new Waiter();

            //开门营业
            girl.SetOrder(bakeChickenWingCommand1);
          
            girl.SetOrder(bakeMuttonCommand2);
           
            girl.SetOrder(bakeChickenWingCommand1);


            //点菜完闭，通知厨房
            girl.Notify();




        }
    }
}
