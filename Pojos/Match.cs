using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojos
{
    public class Match
    {
        [Key]
        public Guid _id { get; set; }
        public string id_duenno { get; set; }
        public string id_usuario { get; set; }


    }
}
