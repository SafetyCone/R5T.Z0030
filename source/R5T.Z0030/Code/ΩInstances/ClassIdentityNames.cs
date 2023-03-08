using System;


namespace R5T.Z0030
{
    public class ClassIdentityNames : IClassIdentityNames
    {
        #region Infrastructure

        public static IClassIdentityNames Instance { get; } = new ClassIdentityNames();


        private ClassIdentityNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0030.Raw
{
    public class ClassIdentityNames : IClassIdentityNames
    {
        #region Infrastructure

        public static IClassIdentityNames Instance { get; } = new ClassIdentityNames();


        private ClassIdentityNames()
        {
        }

        #endregion
    }
}