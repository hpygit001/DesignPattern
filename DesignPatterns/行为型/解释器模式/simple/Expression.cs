﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.解释器模式.simple
{
    abstract class Expression
    {
        /// <summary>
        /// 解释器
        /// </summary>
        /// <param name="context"></param>
        public void Interpret(PlayContext context)
        {
            if(context.PlayText.Length==0)
            {
                return;
            }
            else
            {
                string playKey = context.PlayText.Substring(0, 1);
                context.PlayText = context.PlayText.Substring(2);
                double playValue = Convert.ToDouble(context.PlayText.Substring(0,context.PlayText.IndexOf(' ')));
                context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(' ') + 1);


                Excute(playKey, playValue);

            }


        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public abstract void Excute(string key, double value);

    }
}
