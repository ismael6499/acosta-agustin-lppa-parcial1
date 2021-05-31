using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practica1parciallppa1.Data.Entities
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}