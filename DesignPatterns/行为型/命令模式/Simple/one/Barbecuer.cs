using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式.Simple.one
{
    /// <summary>
    /// 烤肉串者
    /// </summary>
    public class Barbecuer
    {
        /// <summary>
        /// 烤羊肉
        /// </summary>
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串!");
        }

        /// <summary>
        /// 烤鸡翅
        /// </summary>
        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅!");
        }



    }
}
