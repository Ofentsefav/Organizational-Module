using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Functions
    {
        ModuleDetails det = new ModuleDetails();
        int study = 0;
        int remaininghours = 0;
        public int Self_Study()
        {
            study = (ModuleDetails.Module_Credits * 10) / (ModuleDetails.Total_semester_weeks - ModuleDetails.Module_Weekly_classhrs);
            return study;
        }
        public int Remaning()
        {
            remaininghours = Self_Study() - ModuleDetails.Recorded_Hours;
            return remaininghours;
        }
    }
}
