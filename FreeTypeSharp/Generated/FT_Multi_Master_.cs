namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Multi_Master_
    {
        public uint num_axis;
        public uint num_designs;
        public FT_MM_Axis_* axis;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_MM_Axis_
    {
        public byte* name;
        public long minimum;
        public long maximum;
    }
}