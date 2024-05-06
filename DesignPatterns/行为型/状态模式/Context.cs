using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式
{
    class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }


        public State State
        {
            get { return state; }

            set
            {
                state = value;
                Console.WriteLine("当前状态："+state.GetType().Name);
            }


        }

        public void Request()
        {
            state.Handle(this);
        }

    }
}
