﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Models
{
    public class TodoItem
    {
        public long ID { get; set; }
        public string nome { get; set; }
        public bool IsComplete { get; set; }

    }
}
