using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.备忘录模式
{
    /// <summary>
    /// 备忘录
    /// 负责存储Originator对象的内部状态，并可防止Originator 以外的其他对象访问备忘录Memento。
    /// 备忘录有两个接口，Caretaker只能看到备忘录的窄接口，它只能将备忘录传递给其他对象。
    /// Originator 能够看到一个宽接口，允许它访问返回到先前状态所需的所有数据。
    /// </summary>
    class Memento
    {

        private string state;
        public Memento(string state)
        {
            this.state = state;
        }


        public string State
        {
            get { return state; }

        }
    }
}
