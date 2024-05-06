using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式.Simple
{
    abstract class Action
    {
        /// <summary>
        /// 得到男人结论或反应
        /// </summary>
        /// <param name="concreteElemetA"></param>
        public abstract void GetManConclusion(Man concreteElemetA);

        /// <summary>
        /// 得到女人结论或反应
        /// </summary>
        /// <param name="concreteElementB"></param>
        public abstract void GetWomanConclusion(Woman concreteElementB);

    }
}
