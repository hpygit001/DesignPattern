using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.工厂方法
{
    class ProductTest
    {

        public static void Test()
        {
            //IProductFactory productFactory = new  FactoryProductA();


            //AbstractProduct product = productFactory.CreateProduct();

            //product.Show();

            //使用工厂方法测试运算操作
            Simple.IOperationFactory operationFactory = new Simple.FactoryAdd();
            Simple.OperationBase operation = operationFactory.CreateOperation();

            operation.NumberA = 10;
            operation.NumberB = 3;
            Console.WriteLine(operation.GetResult());

        }
    }
}
