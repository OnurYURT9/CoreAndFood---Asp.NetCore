using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Idare
    {
        [Key]
        public int IdareId{ get; set; }
        [StringLength(20)]
        public string Idarekullaniciadi{ get; set; }
        [StringLength(20)]
        public string Idaresifre { get; set; }
        [StringLength(1)]
        public string IdareRole { get; set; }
    }
}
