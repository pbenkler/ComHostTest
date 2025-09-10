using System;
using System.Runtime.InteropServices;

namespace ComHostTest
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("4c493081-116d-434d-852f-b3ff26b0d5ce")]
    public interface ITest
    {
        int this[int index] { get; set; }
    }
}
