using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式.Simple.one
{
    /// <summary>
    /// 烤羊肉串命令
    /// </summary>
    class BakeMuttonCommand:Command
    {
        public BakeMuttonCommand(Barbecuer barbecuer):base(barbecuer)
        {

        }

        /// <summary>
        /// 执行烤羊肉串命令
        /// </summary>
        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
