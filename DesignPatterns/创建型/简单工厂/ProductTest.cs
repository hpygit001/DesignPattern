using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂
{
    class ProductTest
    {

        public static void Test()
        {
            AbstractProduct product = ProductFactory.CreateProduct("A");
            product.Show();


        }
    }
}
