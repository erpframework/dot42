using Dot42.CompilerLib.XModel;

namespace Dot42.CompilerLib.Ast
{
    public abstract class AstVariable : IVariable
    {
        public string Name;
        public bool IsGenerated;
        public XTypeReference Type;

        /// <summary>
        /// Is this variable pinnen?
        /// </summary>
        public abstract bool IsPinned { get; }

        /// <summary>
        /// Is this variable a parameter of the current method?
        /// </summary>
        public abstract bool IsParameter { get; }

        /// <summary>
        /// Is this variable "this"?
        /// </summary>
        public abstract bool IsThis { get; }

        /// <summary>
        /// Gets the original variable object (source specific).
        /// </summary>
        public abstract object OriginalVariable { get; }

        /// <summary>
        /// Gets the original parameter object (source specific).
        /// </summary>
        public abstract object OriginalParameter { get; }

        /// <summary>
        /// Gets the name of the variable as used in the original code (IL/Java).
        /// Can be null
        /// </summary>
        public abstract string OriginalName { get; }

        /// <summary>
        /// Is this property generated by the compiler?
        /// </summary>
        bool IVariable.IsCompilerGenerated
        {
            get { return OriginalName.StartsWith("CS$"); }
        }

        /// <summary>
        /// Gets the name
        /// </summary>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Gets the name of the variable.
        /// Can be null
        /// </summary>
        string IVariable.Name { get { return Name; } }

        /// <summary>
        /// Gets the type of this variable.
        /// </summary>
        TTypeRef IVariable.GetType<TTypeRef>(ITypeResolver<TTypeRef> typeResolver)
        {
            return GetType(typeResolver);
        }

        /// <summary>
        /// Gets the type of this variable.
        /// </summary>
        protected abstract TTypeRef GetType<TTypeRef>(ITypeResolver<TTypeRef> typeResolver);
    }
}