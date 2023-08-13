using System;


namespace R5T.Z0030
{
    public class PathologicalIdentityNameSets : IPathologicalIdentityNameSets
    {
        #region Infrastructure

        public static IPathologicalIdentityNameSets Instance { get; } = new PathologicalIdentityNameSets();


        private PathologicalIdentityNameSets()
        {
        }

        #endregion
    }
}
