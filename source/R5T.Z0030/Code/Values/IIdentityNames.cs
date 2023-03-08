using System;

using R5T.T0131;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IIdentityNames : IValuesMarker
    {
        private static Raw.IIdentityNames RawIdentityNames => Raw.IdentityNames.Instance;


        public TypeIdentityName Type_Basic => TypeIdentityNames.Instance.BasicType;
        public TypeIdentityName Type_ClosedGeneric => TypeIdentityNames.Instance.ClosedGeneric;
        public TypeIdentityName Type_OpenGeneric => TypeIdentityNames.Instance.OpenGeneric;
    }
}


namespace R5T.Z0030.Raw
{
    [ValuesMarker]
    public partial interface IIdentityNames : IValuesMarker
    {
        /// <inheritdoc cref="ITypeIdentityNames.Type01"/>
        public TypeIdentityName Type01 => TypeIdentityNames.Instance.Type01;

        /// <inheritdoc cref="ITypeIdentityNames.Type02"/>
        public TypeIdentityName Type02 => TypeIdentityNames.Instance.Type02;
    }
}
