using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.解释器模式.simple
{
    class PlayContext
    {
        //演奏文本
        private string text;

        public string PlayText
        {
            get { return text; }
            set
            {
                text = value;
            }
        }


    }
}
