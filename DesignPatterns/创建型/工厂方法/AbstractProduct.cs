using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.工厂方法
{

    /*
     * 工厂方法： 定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到子类。
     *          优点：对简单工厂进一步抽象和推广，增加功能时，只需要增相关功能类即可。
     *              
     *          缺点：在增加功能类，增加了额外的工作量，不但增加功能类，还得增加对应的工厂。其二，就是需要修改客户端，将判断分支
     *                交给客户端来做！！！
     * 
     * 
     * 
     */

    /// <summary>
    /// 抽象的产品基类
    /// </summary>
    public abstract class AbstractProduct
    {
        public abstract void Show();
    }
}
