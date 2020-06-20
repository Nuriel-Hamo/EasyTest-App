using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTest_App
{
    class exam_report
    {
        public int exam_report_id { get; set; }
        public int exam_id { get; set; }
        public int proctor_id { get; set; }
        public string type { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string comment { get; set; }
        public int status { get; set; }

    }
}
