using System;

using R5T.T0131;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface ITypeIdentityNames : IValuesMarker
    {
        private static Raw.ITypeIdentityNames RawTypeIdentityNames => Raw.TypeIdentityNames.Instance;


        public ITypeIdentityName BasicType => RawTypeIdentityNames.Type01;

        /// <summary>
        /// It is impossible to directly specify a closed generic type in documentation.
        /// By "direct", I mean get an identity name output that starts with type kind identifier "T:".
        /// You cannot specify the type parameter, only the generic type parameter {T}.
        /// For example, List&lt;T&gt; is:
        /// <para>
        /// &lt;see cref="System.Collections.Generic.List{T}"/&gt;
        /// </para>
        /// And if you try specifying the type parameter like:
        /// <para>
        /// &lt;see cref="System.Collections.Generic.List{System.String}"/&gt;
        /// </para>
        /// You get a warning:
        /// <para>
        /// CS1658: Type parameter declaration must be an identifier not a type. See also error CS0081.
        /// </para>
        /// </summary>
        /// <remarks>
        /// The <see cref="ObsoleteAttribute"/> is used to indicate there is a problem if an attempt is made to use this value. (Obsolete was used because an "ErrorAttribute" does not exist).
        /// </remarks>
        [Obsolete]
        public ITypeIdentityName ClosedGeneric_Direct => throw new NotImplementedException();

        /// <summary>
        /// It <em>is</em> possible to indirectly specify a closed generic type in documentation.
        /// By "indirect", I mean the closed generic type is contained within the identity name of a different member kind, like method.
        /// For example:
        /// <para>
        /// &lt;see cref="ExampleMethods.Method14(System.Collections.Generic.List{string})"/&gt;
        /// </para>
        /// This produces the identity name:
        /// <para>
        /// M:R5T.T0140.ExampleMethods.Method14(System.Collections.Generic.List{System.String})
        /// </para>
        /// The method identity name starts with the method kind identifier "M:", but indirectly contains the identity name for List{string}.
        /// </summary>
        /// <inheritdoc cref="ClosedGeneric_Direct" path="/remarks"/>
        [Obsolete]
        public ITypeIdentityName ClosedGeneric_Indirect => throw new NotImplementedException();

        /// <summary>
        /// Given the impossibility of directly specifying a closed generic type identity name (see <see cref="ClosedGeneric_Direct">ClosedGeneric_Direct</see>),
        /// but the output produced by an indirect specification (see <see cref="ClosedGeneric_Indirect">ClosedGeneric_Indirect</see>),
        /// it is possible to infer what the type identity name of a closed generic type is.
        /// </summary>
        public ITypeIdentityName ClosedGeneric_Inferred => RawTypeIdentityNames.System_Collections_Generic_ListOfString;

        /// <summary>
        /// The type name of a closed generic type, like List&lt;T&gt;.
        /// <para>
        /// Note: see the discussion about how the type name of a closed generic is inferred here: <see cref="ClosedGeneric_Inferred">ClosedGeneric_Inferred</see>.
        /// </para>
        /// </summary>
        public ITypeIdentityName ClosedGeneric => this.ClosedGeneric_Inferred;

        public ITypeIdentityName OpenGeneric => RawTypeIdentityNames.Type02;

        public ITypeIdentityName Generic => this.OpenGeneric;

        public ITypeIdentityName Generic_WithOneTypeParameter => this.Generic;

        public ITypeIdentityName Generic_WithTwoTypeParameters => RawTypeIdentityNames.Type03;
    }
}


namespace R5T.Z0030.Raw
{
    [ValuesMarker]
    public partial interface ITypeIdentityNames : IValuesMarker
    {
        /// <summary>
        /// A familiar closed generic type in a namespace.
        /// <para>
        /// Note: see the discussion about how the type name of a closed generic is inferred here: <see cref="Z0030.ITypeIdentityNames.ClosedGeneric_Inferred">ClosedGeneric_Inferred</see>.
        /// </para>
        /// </summary>
        public ITypeIdentityName System_Collections_Generic_ListOfString => "T:System.Collections.Generic.List{string}".ToTypeIdentityName();

        /// <summary>
        /// A basic type in a namespace.
        /// </summary>
        public ITypeIdentityName Type01 => "T:Namespace01.Namespace02.Type01".ToTypeIdentityName();

        /// <summary>
        /// An open generic type in a namespace with a single type parameter.
        /// </summary>
        public ITypeIdentityName Type02 => "T:Namespace01.Namespace02.Type02`1".ToTypeIdentityName();

        /// <summary>
        /// An open generic type in a namespace with two type parameters.
        /// </summary>
        public ITypeIdentityName Type03 => "T:Namespace01.Namespace02.Type03`2".ToTypeIdentityName();
    }
}