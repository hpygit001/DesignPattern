using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.装饰模式.Simple
{
    class Person
    {
        private string name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",name);
        }
    }
}
