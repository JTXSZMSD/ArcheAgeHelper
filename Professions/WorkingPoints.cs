using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheAgeHelper.Professions
{
    internal static class WorkingPoints
    {
        public static string DailyWorkingPointsCalculate(bool prem, bool premSiol)
        {
            int workingPoints = 1440;
            string wp = "";

            if (prem)
            {
                workingPoints = 2880;
            }
            else if (premSiol)
            {
                workingPoints = 5380;
            }

            wp = workingPoints.ToString();

            return wp;
        }
    }
}
