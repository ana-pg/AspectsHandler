using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostSharp.Aspects;

namespace AspectsHandler
{
    [Serializable]
    public class WinFormMethodBoundary : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }
    }
}
