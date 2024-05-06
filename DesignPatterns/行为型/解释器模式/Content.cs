using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.解释器模式
{
    class Content
    {
        private string input;

        public string Input
        {
            get { return input; }
            set
            {
                input = value;
            }
        }

        private string output;

        public string Output
        {
            get { return output; }
            set
            {
                output = value;
            }
        }
    }
}
