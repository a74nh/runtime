// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*
This test stimulates heap expansion on the finalizer thread
*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Xunit;

public class Test_expandheap
{
    [Fact]
    public static void TestEntryPoint()
    {
        Console.WriteLine("First Alloc");
        GCUtil.Alloc(1024*1024*4, 30);
        GCUtil.FreeNonPins();
        GC.Collect();

        Console.WriteLine("Second Alloc");
        GCUtil.Alloc(1024*1024*4, 50);
        GCUtil.FreeNonPins();
        GC.Collect();
        GCUtil.FreePins();

        Console.WriteLine("Test passed");
    }
}
