using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ModuleDetails
    {
        public static DateTime Semester_start_Date { get; set; }
        public static string Module_Code { get; set; }
        public static string Module_name { get; set; }
        public static int Module_Credits { get; set; }
        public static int Module_Weekly_classhrs { get; set; }
        public static int Total_semester_weeks { get; set; }
        public static DateTime Certain_Day { get; set; }
        public static int Recorded_Hours { get; set; }
        
        public ModuleDetails(DateTime semesstart, string code, string name, int credits, int weeklyclasshrs, int totsemesterweeks, DateTime dayselected, int recordedhrs)
        {
            Semester_start_Date = semesstart;
            Module_Code = code;
            Module_name = name;
            Module_Credits = credits;
            Module_Weekly_classhrs = weeklyclasshrs;
            Total_semester_weeks = totsemesterweeks;
            Certain_Day = dayselected;
            Recorded_Hours = recordedhrs;


        }

        public ModuleDetails()
        {
        }
    }
}
