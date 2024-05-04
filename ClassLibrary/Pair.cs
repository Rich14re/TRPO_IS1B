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
        private readonly string time_pair_start;
        private readonly string time_pair_end;
        private readonly string time_break_start;
        private readonly string time_break_end;
        public readonly Shift shift;
        public Pair(string time_pair_start, string time_pair_end, string time_break_start, string time_break_end, Shift shift)
        {
            this.time_pair_start = time_pair_start;
            this.time_pair_end = time_pair_end;
            this.time_break_start = time_break_start;
            this.time_break_end = time_break_end;
            this.shift = shift;
        }
        public string Time_Pair_Start
        {
            get { return time_pair_start; }
        }
        public string Time_Pair_End
        {
            get { return time_pair_end; }
        }
        public string Time_Break_Start
        {
            get { return time_break_start; }
        }
        public string Time_Break_End
        {
            get { return time_break_end; }
        }
    }
}
