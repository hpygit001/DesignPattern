using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.装饰模式.Simple
{
    class LeatherShoes:Finery
    {
        public override void Show(Person person)
        {
            Console.Write("皮鞋\t");
            base.Show(person);
        }
    }
}
