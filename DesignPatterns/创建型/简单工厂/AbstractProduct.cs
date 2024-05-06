using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.简单工厂
{
    /// <summary>
    /// 简单工厂模式：
    ///             提供一个抽象类，用来约束产品的创建过程，子类继承这个抽象的产品类，实现创建产品的方法；
    ///             再用一个工厂类管理所有子类对象的创建，用户需要输入相关参数获取相关对象。简单的说，工厂类包含的
    ///             对象的创建逻辑及其选择判断，用户不必关心对象的创建过程，只需要知道自己创建的对象即可。
    ///             
    ///             缺点：工厂类耦合了所有对象的创建过程和选择判断，当增加新的产品时，需要修改该工厂；违背的开放封闭原则！
    ///             
    /// </summary>
    public abstract class AbstractProduct
    {

        /// <summary>
        /// 展示当前的产品是啥
        /// </summary>
        public abstract void Show();

    }
}
