using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.备忘录模式
{
    /// <summary>
    /// 发起人
    /// 负责创建一个备忘录Memento，用以记录当前时刻它的内部状态，并可使用备忘录恢复内部状态。
    /// Originator 可根据需要决定Memento 储存Originator 的哪些状态。
    ///  
    /// </summary>
    class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }

        /// <summary>
        /// 创建一个备忘录，将当前需要保存的信息导入实例并创建一个Memento对象
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        /// <summary>
        /// 恢复备忘录，将Memento导入并恢复
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }


        public void Show()
        {
            Console.WriteLine("State= "+state);
        }

    }
}
