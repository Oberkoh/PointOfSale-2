﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int  Fksale { get; set; }
        public int Fkcliente { get; set; }
    }
}
