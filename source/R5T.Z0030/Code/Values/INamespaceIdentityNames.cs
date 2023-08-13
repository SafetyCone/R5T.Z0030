using System;

using R5T.T0131;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface INamespaceIdentityNames : IValuesMarker
    {
        public INamespaceIdentityName Namespace01 => "N:R5T.S0102.N002".ToNamespaceIdentityName();
    }
}
