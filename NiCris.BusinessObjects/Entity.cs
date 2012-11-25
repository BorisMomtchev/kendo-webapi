using System;
using System.ComponentModel.DataAnnotations;
//using System.Linq;

namespace NiCris.BusinessObjects
{
    public abstract class Entity
    {
        [Key]
        public int id { get; set; }
        //public string rowversion { get; set; }
    }
}
