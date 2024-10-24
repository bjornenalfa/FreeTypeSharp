namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Var_Axis_
    {
        public byte* name;
        public IntPtr minimum;
        public IntPtr def;
        public IntPtr maximum;
        public UIntPtr tag;
        public uint strid;
    }
}