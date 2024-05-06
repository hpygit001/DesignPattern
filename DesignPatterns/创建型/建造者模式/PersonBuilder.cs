using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.建造者模式
{
    /// <summary>
    /// 一个抽象的人，包含一个人的所有组成部分
    /// </summary>
    abstract class PersonBuilder
    {
        public abstract void BulidHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();


    }
}
