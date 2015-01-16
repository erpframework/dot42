﻿using System.Reflection;

namespace Dot42.Ide.Serialization.Nodes.XmlResource
{
    /// <summary>
    /// resources/array/item
    /// </summary>
    [ElementName("item", null, "array")]
    [Obfuscation(Feature = "@SerializableNode")]
    public sealed class TypedArrayItemNode : ValueNode
    {
        /// <summary>
        /// Accept a visit by the given visitor.
        /// </summary>
        public override TReturn Accept<TReturn, TData>(SerializationNodeVisitor<TReturn, TData> visitor, TData data)
        {
            return visitor.Visit(this, data);
        }
    }
}
