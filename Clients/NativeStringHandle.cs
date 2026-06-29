
using System.Runtime.InteropServices;

namespace BlazorEmpty.Clients;

public sealed class NativeStringHandle : SafeHandle
{
    // Required by the marshaller
    private NativeStringHandle() : base(IntPtr.Zero, ownsHandle: true)
    {
    }

    public override bool IsInvalid => handle == IntPtr.Zero;

    protected override bool ReleaseHandle()
    {
        PaylinkBinding.freeString(handle);
        return true;
    }

    public string GetString()
    {
        return Marshal.PtrToStringUTF8(handle)!;
    }

}
