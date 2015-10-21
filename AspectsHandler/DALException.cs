using System;
using System.Collections.Generic;
using System.Text;
using PostSharp.Aspects;

namespace AspectsHandler
{
    [Serializable]
    public class DALException : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            //base.OnException(args);
        }
    }
}
