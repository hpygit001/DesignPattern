using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.抽象工厂
{
    /// <summary>
    /// 抽象工厂，包含了所有对象的创建方法
    ///         抽象工厂模式（Abstract Factory）：提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。
    ///         抽象工厂模式用来解决多个产品系列的问题。
    ///         
    /// 
    /// 
    /// 
    /// </summary>
    abstract class AbstractFactory
    {
        public  abstract  AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();

    }
}
