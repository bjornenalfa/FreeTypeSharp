namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Var_Named_Style_
    {
        public IntPtr* coords;
        public uint strid;
        public uint psid;
    }
}