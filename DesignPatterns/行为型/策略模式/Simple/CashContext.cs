using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.策略模式.Simple
{
    class CashContext
    {
        private CashSuper cs;

        public CashContext(string type)
        {
            switch(type)
            {
                case "正常收费":
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;

                    break;
                case "满300返100":
                    CashReturn cr1 = new CashReturn("300", "100");
                    cs = cr1;
                    break;


                case "打8折":
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;

                    break;


            }
        }


        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }



    }
}
