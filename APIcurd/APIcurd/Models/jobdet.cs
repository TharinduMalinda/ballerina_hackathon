using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIcurd.Models
{
    public class jobdet
    {
        public int JobID { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string JobCategory { get; set; }
    }
}