using System;


namespace R5T.Z0030
{
    public class MethodIdentityNames : IMethodIdentityNames
    {
        #region Infrastructure

        public static IMethodIdentityNames Instance { get; } = new MethodIdentityNames();


        private MethodIdentityNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0030.Raw
{
    public class MethodIdentityNames : IMethodIdentityNames
    {
        #region Infrastructure

        public static IMethodIdentityNames Instance { get; } = new MethodIdentityNames();


        private MethodIdentityNames()
        {
        }

        #endregion
    }
}
