using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Service
{
    public static class ConvertTime
    {
        public static DateTime toUAEDateTime(DateTime localTime)
        {
            TimeZoneInfo timeZoneInfo;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            }
            else
            {
                timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Asia/Dubai");
            }

            return TimeZoneInfo.ConvertTimeFromUtc(localTime, timeZoneInfo);
        }
    }
}
