﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviva.NumberDetection.Concretes
{
    public class OutOfBoundsException:Exception
    {
        public OutOfBoundsException(string message):base(message)
        {
        }
    }
}
