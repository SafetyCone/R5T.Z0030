using System;


namespace R5T.Z0030
{
    public class NamespaceIdentityNames : INamespaceIdentityNames
    {
        #region Infrastructure

        public static INamespaceIdentityNames Instance { get; } = new NamespaceIdentityNames();


        private NamespaceIdentityNames()
        {
        }

        #endregion
    }
}
