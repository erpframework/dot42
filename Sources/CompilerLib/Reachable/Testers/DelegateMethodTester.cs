﻿using System.ComponentModel.Composition;
using Dot42.CecilExtensions;
using Dot42.CompilerLib.Reachable.DotNet;
using Mono.Cecil;

namespace Dot42.CompilerLib.Reachable.Testers
{
    [Export(typeof(IIncludeMethodTester))]
    public class DelegateMethodTester : IIncludeMethodTester
    {
        /// <summary>
        /// Should the given method be included in the APK?
        /// </summary>
        public bool Include(MethodDefinition method, ReachableContext context)
        {
            var rc = method.DeclaringType.IsDelegate();
            return rc;
        }
    }
}
