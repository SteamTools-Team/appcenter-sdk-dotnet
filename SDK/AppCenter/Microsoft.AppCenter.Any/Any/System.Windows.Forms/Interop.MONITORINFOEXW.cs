﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// https://github.com/dotnet/winforms/blob/v6.0.1/src/System.Windows.Forms.Primitives/src/Interop/User32/Interop.MONITORINFOEXW.cs

#if !NETFRAMEWORK
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class User32
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct MONITORINFOEXW
        {
            public uint cbSize;
            public RECT rcMonitor;
            public RECT rcWork;
            public MONITORINFOF dwFlags;
            public fixed char szDevice[32];
        }
    }
}
#endif