using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Snapp.Core.Generators
{
    public static class DateTimeGenerator
    {
        static PersianCalendar pc = new PersianCalendar();
        public static string GetShamsiDate()
        {
            // 0000/00/00
            return pc.GetYear(DateTime.Now).ToString("0000") + "/" +
                pc.GetMonth(DateTime.Now).ToString("00") + "/" +
                pc.GetDayOfMonth(DateTime.Now).ToString("00");
        }

        public static string GetShamsiTime()
        {
            // 00:00:00
            return pc.GetHour(DateTime.Now).ToString("00") + ":" +
                pc.GetMinute(DateTime.Now).ToString("00") + ":" +
                pc.GetSecond(DateTime.Now).ToString("00");
        }
    }
}
