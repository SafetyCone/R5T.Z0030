using System;

using R5T.T0131;
using R5T.T0143;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IClassIdentityNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IClassIdentityNames _Raw => Raw.ClassIdentityNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public ITypeIdentityName BasicClass => _Raw.Class01;
        public ITypeIdentityName GenericClass => _Raw.Class01;
    }
}


namespace R5T.Z0030.Raw
{
    [ValuesMarker]
    public partial interface IClassIdentityNames : IValuesMarker
    {
        public ITypeIdentityName Class01 => "T:Namespace01.Namespace02.Class01".ToTypeIdentityName();
        public ITypeIdentityName Class02 => "T:Namespace01.Namespace02.Class02`1".ToTypeIdentityName();
    }
}
