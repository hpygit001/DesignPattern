using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式.Simple.one
{
    /// <summary>
    /// 烤鸡翅命令
    /// </summary>
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer barbecuer):base(barbecuer)
        {

        }


        /// <summary>
        /// 执行烤鸡翅命令
        /// </summary>
        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
