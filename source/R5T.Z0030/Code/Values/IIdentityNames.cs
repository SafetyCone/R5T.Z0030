using System;

using R5T.T0131;
using R5T.T0162;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IIdentityNames : IValuesMarker
    {
        private static Raw.IIdentityNames RawIdentityNames => Raw.IdentityNames.Instance;


        public ITypeIdentityName Type_Basic => TypeIdentityNames.Instance.BasicType;
        public ITypeIdentityName Type_ClosedGeneric => TypeIdentityNames.Instance.ClosedGeneric;
        public ITypeIdentityName Type_OpenGeneric => TypeIdentityNames.Instance.OpenGeneric;
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
    }
}
