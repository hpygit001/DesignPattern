using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式.Simple
{
    class Failing : Action
    {
        public override void GetManConclusion(Man concreteElemetA)
        {
            Console.WriteLine("{0} {1} 时, 闷头和酒，谁也不用劝。",concreteElemetA.GetType().Name,this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0} {1} 时, 眼泪汪汪，谁也劝不了。",concreteElementB.GetType().Name,this.GetType().Name);
        }
    }
}
