using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.抽象工厂.Simple
{
    class ProductB2 : AbstractProductB
    {
        public override void Play()
        {
            Console.WriteLine($"你可以玩{this.GetType().Name}");
        }
    }
}
