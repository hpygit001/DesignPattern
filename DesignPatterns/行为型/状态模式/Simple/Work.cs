using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.状态模式.Simple
{
    class Work
    {
        private WorkState current;

        public Work()
        {
            current = new ForenoonState();
        }

        private double hour;
        public double Hour
        {
            get { return hour; }
            set
            {
                hour = value;
            }
        }

        private bool finish = false;
        public bool TaskFinished
        {
            get { return finish; }
            set
            {
                finish = value;
            }

        }

        public void SetState(WorkState ws)
        {
            current = ws;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }

    }
}
