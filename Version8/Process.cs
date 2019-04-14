using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schdular
{
    class Process
    {
        private string name;
        private int priority;
        private int brust_time;
        private int arrival_time;
        private int waiting_time;
        private int start_time;
        private int finish_time;

        public String Name { get; set; }
        public int Priority { get; set; }
        public int Brust_time { get; set; }
        public int Brust_time_save { get; set; }
        public int Arrival_time { get; set; }
        public int Waiting_time { get; set; }
        public int Start_time { get; set; }
        public int Finish_time { get; set; }

        public Process()
        {

            name = "";
            priority = 0;

            brust_time = 0;

            arrival_time = 0;
            waiting_time = 0;
            start_time = -1;
            finish_time = -1;
            Start_time = -1;
            Finish_time=-1;

        }
        


    }
}
