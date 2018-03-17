using System;

namespace ProjectEuler.Tasks
{
    public static class Problem19
    {
        public static long CountSundaysOnFirstDayOfMonth(DateTime from, DateTime to)
        {
            var count = 0;
            for (var curr = from; curr < to; curr = curr.AddDays(1))
            {
                if (curr.DayOfWeek == DayOfWeek.Sunday && curr.Day == 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
