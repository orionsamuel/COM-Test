using System;
using System.Runtime.InteropServices;

namespace MyCSharpClass
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("485B98AF-53D4-4148-B2BD-CC3920BF0ADF")]
    public class TheClass
    {
        public String GetTheThing(String arg)
        {
            return arg + " the thing";
        }
    }
}
