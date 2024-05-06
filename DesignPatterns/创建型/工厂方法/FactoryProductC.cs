using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.工厂方法
{
    /// <summary>
    /// 创建产品C的工厂
    /// </summary>
    class FactoryProductC : IProductFactory
    {
        public AbstractProduct CreateProduct()
        {
            return new ProductC();
        }
    }
}
