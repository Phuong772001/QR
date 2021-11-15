﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingPhone.Aplication.Entities
{
    [Table("Mausacs")]
   public class Mausac
    {
        [Key]
        public int Id { get; set; }
        public string Color { get; set; }
        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }

    }
}
