﻿namespace TestSolutionPlugins.UnitTest
{
    using DLaB.Xrm.Test;
    using System.Diagnostics;

    public class DebugLogger : ITestLogger
    {
        public void WriteLine(string message)
        {
            Debug.WriteLine(message);
        }

        public void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(format, args);
        }
    }
}
