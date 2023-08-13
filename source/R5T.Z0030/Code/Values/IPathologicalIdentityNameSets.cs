using System;

using R5T.T0131;
using R5T.T0162;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IPathologicalIdentityNameSets : IValuesMarker
    {
        private static readonly Lazy<IIdentityName[]> zAll = new Lazy<IIdentityName[]>(() => new[]
        {
            // Ordered in ascending order of validity.
            Instances.PathologicalIdentityNames.Null,
            Instances.PathologicalIdentityNames.Empty,
            Instances.PathologicalIdentityNames.TooShort,
            Instances.PathologicalIdentityNames.Invalid_KindMarker,
            Instances.PathologicalIdentityNames.Without_KindMarkerSeparator,
        });

        public IIdentityName[] All => zAll.Value;
    }
}
