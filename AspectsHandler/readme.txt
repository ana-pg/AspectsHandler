1. add project to solution
2. reference it from wanted project
3. edit (your) project's AssemblyInfo.cs - add line(s) to the end:
Examples:
- for using (tracing all actions) in your DAL for all classes inside namespace called 'MyNamespace':
    [assembly: AspectsHandler.DALMethodBoundary(AttributeTargetTypes = "MyNamespace.*")] 

-for using (handling exceptions) in particular BLL classes:
    [assembly: AspectsHandler.BLLException(AttributeTargetTypes = "MyNamespace1.MyCustomClass1")] 
    [assembly: AspectsHandler.BLLException(AttributeTargetTypes = "MyNamespace2.MyCustomClass2")] 
    ...