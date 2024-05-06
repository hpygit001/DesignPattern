using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.建造者模式
{
    /// <summary>
    /// 胖小人
    /// </summary>
    class PersonFatBuilder : PersonBuilder
    {
        public override void BuildArmLeft()
        {
            Console.Write("胖的左胳膊\t");
        }

        public override void BuildArmRight()
        {
            Console.Write("胖的右胳膊\t");
        }

        public override void BuildBody()
        {
            Console.Write("胖的身体\t");
        }

        public override void BuildLegLeft()
        {
            Console.Write("胖的左腿");
        }

        public override void BuildLegRight()
        {
            Console.Write("胖的右腿");
        }

        public override void BulidHead()
        {
            Console.Write("胖的脑袋");
        }
    }
}
