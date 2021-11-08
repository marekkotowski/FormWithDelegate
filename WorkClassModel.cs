using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormWithDelegate
{
    public delegate void ShowInfo(string  _info); 

    public class WorkClassModel
    {
        public WorkClassModel()
        { 
        
        }


        public void DoAnalysis(ShowInfo t)
        {
            t("Start of analisys...");
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(500);
            }
            t("Analysis done !!!!");
        }


        public void CheckResult(ShowInfo t)
        {
            int _liczbawykonan=0; 
            t("Check results...");
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(500);
                _liczbawykonan = i; 
            }
            t($"Calculation result: {_liczbawykonan}");
        }
    }
}
