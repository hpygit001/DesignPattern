using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂
{
    class ProductC : AbstractProduct
    {
        public override void Show()
        {
            Console.WriteLine("当前的产品是：" + this.GetType().Name);
        }
    }
}
