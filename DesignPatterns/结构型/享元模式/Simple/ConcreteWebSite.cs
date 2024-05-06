using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.享元模式.Simple
{
    class ConcreteWebSite:WebSite
    {

        private string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use()
        {
            Console.WriteLine("网站分类："+name);
        }
    }
}
