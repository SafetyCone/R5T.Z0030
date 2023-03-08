using System;


namespace R5T.Z0030
{
    public class TypeIdentityNames : ITypeIdentityNames
    {
        #region Infrastructure

        public static ITypeIdentityNames Instance { get; } = new TypeIdentityNames();


        private TypeIdentityNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0030.Raw
{
    public class TypeIdentityNames : ITypeIdentityNames
    {
        #region Infrastructure

        public static ITypeIdentityNames Instance { get; } = new TypeIdentityNames();


        private TypeIdentityNames()
        {
        }

        #endregion
    }
}
