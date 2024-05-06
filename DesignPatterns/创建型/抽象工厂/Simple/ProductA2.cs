using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.抽象工厂.Simple
{
    class ProductA2 : AbstractProductA
    {
        public override void Show()
        {
            Console.WriteLine($"这是{this.GetType().Name}");
        }
    }
}
