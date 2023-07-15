using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    internal class Addition
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void SumOfTwoNumbers(int firstNumber, int secondNumber)
        {
            int sum = 0;
            if (firstNumber <= 0 || secondNumber <= 0)
            {
                logger.Warn("Inputs should be greater than zero");
                logger.Error("Give proper +ve inputs");
            }
            else
            {
                sum = firstNumber + secondNumber;
                logger.Info("Successfully added numbers and result is:{0}", sum);
           
            }
        }
    }
}
