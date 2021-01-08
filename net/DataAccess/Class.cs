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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cid { get; set; }
        public string cname { get; set; }    
        public int grade { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
