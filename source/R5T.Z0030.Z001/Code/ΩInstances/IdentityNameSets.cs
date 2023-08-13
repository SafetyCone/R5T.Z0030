using System;


namespace R5T.Z0030.Z001
{
    public class IdentityNameSets : IIdentityNameSets
    {
        #region Infrastructure

        public static IIdentityNameSets Instance { get; } = new IdentityNameSets();


        private IdentityNameSets()
        {
        }

        #endregion
    }
}
