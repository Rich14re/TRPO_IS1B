using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pair
    {
        /// <summary>
        /// Время должно храниться в TimeSpan
        /// </summary>
        private readonly TimeSpan time_pair_start;
        private readonly TimeSpan time_pair_end;
        private readonly TimeSpan time_break_start;
        private readonly TimeSpan time_break_end;
        private readonly Shift shift;

        public Pair(TimeSpan time_pair_start, TimeSpan time_pair_end, TimeSpan time_break_start, TimeSpan time_break_end, Shift shift)
        {
            this.time_pair_start = time_pair_start;
            this.time_pair_end = time_pair_end;
            this.time_break_start = time_break_start;
            this.time_break_end = time_break_end;
            this.shift = shift;
        }

        public TimeSpan Time_Pair_Start
        {
            get { return time_pair_start; }
        }
        public Shift Shift
        {
            get { return shift; }
        }
        public TimeSpan Time_Pair_End
        {
            get { return time_pair_end; }
        }

        public TimeSpan Time_Break_Start
        {
            get { return time_break_start; }
        }

        public TimeSpan Time_Break_End
        {
            get { return time_break_end; }
        }
    }
}
