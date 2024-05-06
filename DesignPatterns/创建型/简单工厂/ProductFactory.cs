using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂
{
    /// <summary>
    /// 产品工厂的创建类
    /// </summary>
    class ProductFactory
    {

        public static AbstractProduct CreateProduct(string product)
        {
            if (string.IsNullOrEmpty(product)) throw new Exception("传入的产品参数为空或null");
           
            switch(product.ToUpper())
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                case "C":
                    return new ProductC();
                default:
                    throw new Exception($"无法创建产品参数为{product}的对象，该产品不存在！");

            }



           

        }
    }
}
