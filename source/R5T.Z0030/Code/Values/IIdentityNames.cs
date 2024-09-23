using System;

using R5T.T0131;
using R5T.T0143;
using R5T.T0162;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IIdentityNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IIdentityNames _Raw => Raw.IdentityNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public IIdentityName Basic => Instances.TypeIdentityNames.BasicType;

        public IError Error_Basic => _Raw.Error01;

        public ITypeIdentityName Type_Basic => TypeIdentityNames.Instance.BasicType;
        public ITypeIdentityName Type_ClosedGeneric => TypeIdentityNames.Instance.ClosedGeneric;
        public ITypeIdentityName Type_OpenGeneric => TypeIdentityNames.Instance.OpenGeneric;

        public INamespaceIdentityName Namespace_Basic => Instances.NamespaceIdentityNames.Namespace01;
    }
}


namespace R5T.Z0030.Raw
{
    [ValuesMarker]
    public partial interface IIdentityNames : IValuesMarker
    {
        /// <inheritdoc cref="ITypeIdentityNames.Type01"/>
        public ITypeIdentityName Type01 => TypeIdentityNames.Instance.Type01;

        /// <inheritdoc cref="ITypeIdentityNames.Type02"/>
        public ITypeIdentityName Type02 => TypeIdentityNames.Instance.Type02;

        public IError Error01 => Instances.Errors.Error01;
    }
}
