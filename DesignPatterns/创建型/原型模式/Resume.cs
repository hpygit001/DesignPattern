using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.原型模式
{
    /// <summary>
    /// 原型模式(Prototype): 用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
    ///                      
    ///                 优点：每次创建新的对象时，不会调用构造函数。可以隐藏对象的创建细节，如果构造函数的执行时间很长时，那么对性能会有很大的提升。
    ///                 
    ///                 缺点: 需要考虑浅复制与深复制，当存在类的内部含有引用类型时，需要考虑复制的嵌套；如果存在循环引用时，克隆会变得很复杂。
    /// 
    /// </summary>
    class Resume : TestICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.GetType().Name} 构造函数执行...");
        }


        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }


        /// <summary>
        /// 设置工作经历
        /// </summary>
        /// <param name="timeArea"></param>
        /// <param name="company"></param>
        public void SetWorkExperience(string timeArea,string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }


        public void Display()
        {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"工作经历： {timeArea} {company}");
        }






        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
