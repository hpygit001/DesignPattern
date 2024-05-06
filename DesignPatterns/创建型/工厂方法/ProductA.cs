using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.工厂方法
{
    class ProductA : AbstractProduct
    {
        public override void Show()
        {
            Console.WriteLine("当前产品是："+this.GetType().Name);
        }
    }
}
