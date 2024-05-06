using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式.Simple
{
    class Amativeness : Action
    {
        public override void GetManConclusion(Man concreteElemetA)
        {
            Console.WriteLine("{0} {1}时, 凡事不懂也要装懂。",concreteElemetA.GetType().Name,this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0} {1} 时, 遇事懂也装作不懂。",concreteElementB.GetType().Name,this.GetType().Name);
        }
    }
}
