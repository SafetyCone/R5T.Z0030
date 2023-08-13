using System;


namespace R5T.Z0030
{
    public class PathologicalIdentityNames : IPathologicalIdentityNames
    {
        #region Infrastructure

        public static IPathologicalIdentityNames Instance { get; } = new PathologicalIdentityNames();


        private PathologicalIdentityNames()
        {
        }

        #endregion
    }
}
