using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Models
{
    public class TodoItemDTO
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public bool IsComplete { get; set; }
    }
}
