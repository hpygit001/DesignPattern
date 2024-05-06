using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.原型模式
{
    class TestICloneable
    {


        public static void Test()
        {
            Resume resume = new Resume("晶晶");
            resume.SetPersonalInfo("女", "18");
            resume.SetWorkExperience("苏州", "地狱");
            resume.Display();


            Resume resume1=resume.Clone() as Resume;

            resume1.SetPersonalInfo("女", "28");
            resume1.Display();


        }
    }
}
