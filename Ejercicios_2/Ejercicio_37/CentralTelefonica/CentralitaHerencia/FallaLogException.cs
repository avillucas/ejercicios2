﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class FallaLogException : Exception
    {
        public FallaLogException(string errorString, Exception internalError)
            :base(errorString,internalError)
        {}
    }
}
