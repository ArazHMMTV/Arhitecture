﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Business.Exceptions
{
    public class DublicateCategory:Exception 
    {
        public DublicateCategory(string? message):base(message) { }
        
    }
}
