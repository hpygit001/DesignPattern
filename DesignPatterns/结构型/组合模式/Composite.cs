using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.组合模式
{
    /// <summary>
    /// Composite 定义有枝节点行为，用来存储子部件，在Component 接口实现与子部件有关的操作，
    /// 比如增加Add 和删除Remove
    /// </summary>
    class Composite : Component
    {

        public Composite(string name):base(name)
        {

        }

        private List<Component> childern = new List<Component>();

        public override void Add(Component c)
        {
            childern.Add(c);
        }

      

        public override void Remove(Component c)
        {
            childern.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var item in childern)
            {
                item.Display(depth+2);
            }



        }
    }
}
