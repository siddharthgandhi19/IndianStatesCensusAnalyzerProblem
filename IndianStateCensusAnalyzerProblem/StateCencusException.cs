﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerTestPoblem
{
    public class StateCencusException : Exception
    {
        public enum ExceptionType
        {
            FILE_INCORRECT, TYPE_INCORRECT, DELIMETER, HEADER_INCORRECT
        }
        public ExceptionType type;
        public StateCencusException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
