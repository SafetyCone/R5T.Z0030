using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030.Z001
{
    [FunctionalityMarker]
    public partial interface IIdentityNamesFileOperator : IFunctionalityMarker
    {
        public async Task<IIdentityName[]> Get_DotnetPackIdentityNames()
        {
            var dotnetPackIdentityNameValues = await Instances.FileOperator.ReadAllLines(
                Instances.FilePaths.DotnetPackIdentityNames.Value);

            var output = dotnetPackIdentityNameValues
                .Select(x => x.ToIdentityName())
                .Now();

            return output;
        }

        public async Task<IIdentityName[]> Get_RivetIdentityNames()
        {
            var dotnetPackIdentityNameValues = await Instances.FileOperator.ReadAllLines(
                Instances.FilePaths.RivetIdentityNames.Value);

            var output = dotnetPackIdentityNameValues
                .Select(x => x.ToIdentityName())
                .Now();

            return output;
        }

        public async Task<IIdentityName[]> Get_IdentityNames()
        {
            var gettingDotnetPackIdentityNames = this.Get_DotnetPackIdentityNames();
            var gettingRivetIdentityNames = this.Get_RivetIdentityNames();

            var dotnetPackIdentityNames = await gettingDotnetPackIdentityNames;
            var rivetIdentityNames = await gettingRivetIdentityNames;

            var output = dotnetPackIdentityNames
                .Append(rivetIdentityNames)
                .ToArray();

            return output;
        }
    }
}
