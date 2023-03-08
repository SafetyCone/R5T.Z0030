using System;


namespace R5T.Z0030
{
    public class IdentityNames : IIdentityNames
    {
        #region Infrastructure

        public static IIdentityNames Instance { get; } = new IdentityNames();


        private IdentityNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0030.Raw
{
    public class IdentityNames : IIdentityNames
    {
        #region Infrastructure

        public static IIdentityNames Instance { get; } = new IdentityNames();


        private IdentityNames()
        {
        }

        #endregion
    }
}