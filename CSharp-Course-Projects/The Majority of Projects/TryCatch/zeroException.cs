using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch
{
    public class zeroException : Exception
    {
        public zeroException()
          : base() { }
        public zeroException(string message)
            : base(message) { }



    }
}
