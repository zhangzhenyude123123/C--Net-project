using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.DataAccess
{
    class Class
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }    
        public int mid { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
