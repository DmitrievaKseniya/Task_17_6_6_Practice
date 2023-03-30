using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_6_Practice.TypeAccount
{
    public class SalaryAccount : Account, ITypeAccount
    {
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}
