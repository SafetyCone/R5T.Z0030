using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0162;


namespace R5T.Z0030.Z001
{
    [ValuesMarker]
    public partial interface IIdentityNameSets : IValuesMarker
    {
        /// <summary>
        /// Gets both <see cref="DotnetPack"/> and <see cref="Rivet"/> identity names.
        /// </summary>
        public Task<IIdentityName[]> All => Instances.IdentityNamesFileOperator.Get_IdentityNames();

        /// <summary>
        /// Gets identity names present in the dotnet pack.
        /// </summary>
        public Task<IIdentityName[]> DotnetPack => Instances.IdentityNamesFileOperator.Get_DotnetPackIdentityNames();

        /// <summary>
        /// Gets Rivet identity names.
        /// </summary>
        public Task<IIdentityName[]> Rivet => Instances.IdentityNamesFileOperator.Get_RivetIdentityNames();
    }
}
