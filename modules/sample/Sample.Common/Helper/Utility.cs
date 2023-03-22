using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Shared.Helper
{
    public static class Utility
    {
		public static DateTime ToDateTime(object obj)
		{
			DateTime result;

			if (!DateTime.TryParse(obj.ToString(), out result))
			{
				result = new DateTime();
			}
			return result;
		}
		public static string TimeSpanToString(TimeSpan timeStr)
		{
			string hour = (timeStr.Days * 24 + timeStr.Hours).ToString("00");
			string minute = timeStr.Minutes.ToString("00");
			return $"{hour}:{minute}";
		}
	}
}
