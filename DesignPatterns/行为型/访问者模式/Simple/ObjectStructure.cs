using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式.Simple
{
    class ObjectStructure
    {
        private IList<Person> elements = new List<Person>();

        //增加
        public void Attach(Person element)
        {
            elements.Add(element);
        }

        //移除
        public void Detach(Person element)
        {
            elements.Remove(element);
        }

        public void Display(Action visitor)
        {
            foreach (var item in elements)
            {
                item.Accept(visitor);
            }
        }

    }
}
