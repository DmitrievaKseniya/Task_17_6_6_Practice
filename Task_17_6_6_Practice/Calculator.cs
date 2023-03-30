using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_17_6_6_Practice.TypeAccount;

namespace Task_17_6_6_Practice
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(ITypeAccount typeAccount)
        {
            typeAccount.CalculateInterest();
        }
    }   
}
