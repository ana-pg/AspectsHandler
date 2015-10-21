using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace AspectsHandler
{
    [Serializable]
    public class BLLException : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }
    }
}
