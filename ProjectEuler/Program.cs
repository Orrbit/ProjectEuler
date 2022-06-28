using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ProjectEuler.Problems.EvenFibonacciNumbers;
using System;

namespace ProjectEuler
{
    
    class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
