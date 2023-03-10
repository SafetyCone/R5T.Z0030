using System;

using R5T.T0131;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IClassIdentityNames : IValuesMarker
    {
        private static Raw.IClassIdentityNames RawClassIdentityNames => Raw.ClassIdentityNames.Instance;


        public TypeIdentityName BasicClass => RawClassIdentityNames.Class01;
        public TypeIdentityName GenericClass => RawClassIdentityNames.Class01;
    }
}


namespace R5T.Z0030.Raw
{
    [ValuesMarker]
    public partial interface IClassIdentityNames : IValuesMarker
    {
        public TypeIdentityName Class01 => "T:Namespace01.Namespace02.Class01".ToTypeIdentityName();
        public TypeIdentityName Class02 => "T:Namespace01.Namespace02.Class02`1".ToTypeIdentityName();
    }
}
