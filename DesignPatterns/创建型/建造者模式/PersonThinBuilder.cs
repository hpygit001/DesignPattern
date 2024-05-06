using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.建造者模式
{
    /// <summary>
    /// 瘦小人
    /// </summary>
    class PersonThinBuilder : PersonBuilder
    {
        public override void BuildArmLeft()
        {
            Console.Write("瘦左胳膊\t");
        }

        public override void BuildArmRight()
        {
            Console.Write("瘦右胳膊\t");
        }

        public override void BuildBody()
        {
            Console.Write("瘦的身体\t");
        }

        public override void BuildLegLeft()
        {
            Console.Write("瘦的左腿\t");
        }

        public override void BuildLegRight()
        {
            Console.Write("瘦的右腿\t");
        }

        public override void BulidHead()
        {
            Console.Write("瘦的脑袋\t");
        }
    }
}
