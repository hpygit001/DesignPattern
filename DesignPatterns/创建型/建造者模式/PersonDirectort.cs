using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.建造者模式
{
    /// <summary>
    /// 小人的构建过程的指挥者，按照一定顺序负责构建小人
    /// 隔离用户与建造过程的关联
    /// 
    ///         建造者模式(Builder)： 将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
    /// 
    /// 
    /// </summary>
    class PersonDirector
    {
        private PersonBuilder pb;

        public PersonDirector(PersonBuilder pb)
        {
            this.pb = pb;
        }

        public void CreatePerson()
        {
            Console.WriteLine("开始创建小人：");
            Console.Write("\t\t");
            pb.BulidHead();
            pb.BuildBody();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();



        }


    }
}
