using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.装饰模式.Simple
{
    class TShirts:Finery
    {
        public override void Show(Person person)
        {
            Console.Write("大T恤\t");
            base.Show(person);
        }


    }
}
