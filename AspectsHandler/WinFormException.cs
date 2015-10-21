using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostSharp.Aspects;

namespace AspectsHandler
{
    [Serializable]
    public class WinFormException : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }
    }
}
