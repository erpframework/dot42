﻿using System;
using System.ComponentModel.Composition;
using Dot42.ImportJarLib;
using Dot42.ImportJarLib.Custom;
using Dot42.ImportJarLib.Model;

namespace Dot42.FrameworkBuilder.Custom
{
    /// <summary>
    /// Helper used to build type definitions from ClassFile's
    /// </summary>
    [Export(typeof(ICustomTypeBuilder))]
    internal sealed class SystemByteBuilder : BoxedBuilder
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public SystemByteBuilder()
            : base("System", "Byte")
        {
        }

        /// <summary>
        /// Gets the type of the value field
        /// </summary>
        protected override NetTypeReference GetValueType(TargetFramework target)
        {
            return target.TypeNameMap.GetByType(typeof(Byte));
        }
    }
}
