using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.策略模式.Simple
{
    /// <summary>
    /// 返利收费子类
    /// </summary>
    class CashReturn : CashSuper
    {

        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition,string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }



        public override double acceptCash(double money)
        {
            double result = money;
            if(money>=moneyCondition)
            {
                result= money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}
