using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class RecourseManager
    {
        //Method injection(loglama metodu için)
        public void getRecourse(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void MakeALoanPreinformaiton(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
