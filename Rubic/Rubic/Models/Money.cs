using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Models
{
    public class Money
    {
        public int Id { get; set; }
        public int Summ { get; set; }
        public string Operation { get; set; }
        public DateTime? Date { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
