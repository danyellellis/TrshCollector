using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector
{
    public class Role
    {
        [Key]

        public string Customer { get; set; }
        public string Employee { get; set; }

    }

}
