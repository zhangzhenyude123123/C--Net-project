﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.DataAccess
{
    class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ssid { get; set; }
        public string sname { get; set; }
        public string ssex { get; set; }
        public int cid { get; set; }
        public virtual Class Class { get; set; }

    }
}
