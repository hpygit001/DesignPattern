using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.备忘录模式
{
    /// <summary>
    /// 管理者类
    /// 负责保存好备忘录Memento,不能对备忘录的内容进行操作或检查。
    /// 
    /// 
    /// </summary>
    class Caretaker
    {

        private Memento memento;

        public Memento Memento
        {
            get { return memento; }
            set
            {
                memento = value;
            }
        }

    }
}
