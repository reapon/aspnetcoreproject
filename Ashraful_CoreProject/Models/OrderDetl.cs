using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ashraful_CoreProject.Models
{
    public class OrderDetl
    {
        [Key]
        public int Id { get; set; }
        public int MastId { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public decimal Rate { get; set; }

        [ForeignKey("MastId")]
        public virtual OrderMast OrderMast { get; set; }
    }
}
