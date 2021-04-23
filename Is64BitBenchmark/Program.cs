/***********************************************************************
 * Copyright (c) 2021 Matthias Reiseder. All rights reserved.
 * Licensed under the MIT License.
 * See LICENSE file in the repository root for full license information.
 * 
 * Made with BenchmarkDotNet
 * https://github.com/dotnet/BenchmarkDotNet
 **********************************************************************/

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Is64BitBenchmark
{
    public class Is64BitBenchmark
    {
        [Benchmark]
        public bool Is64BitEnvironment()
        {
            bool is64Bit = Environment.Is64BitOperatingSystem;
            return is64Bit;
        }

        [Benchmark]
        public bool Is64BitGreater()
        {
            bool is64Bit = IntPtr.Size > 4;
            return is64Bit;
        }

        [Benchmark]
        public bool Is64BitEqual()
        {
            bool is64Bit = IntPtr.Size == 8;
            return is64Bit;
        }
    }

    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<Is64BitBenchmark>();
            Console.ReadKey();
        }
    }
}
