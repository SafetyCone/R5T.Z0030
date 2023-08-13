using System;


namespace R5T.Z0030.Z001
{
    public class IdentityNamesFileOperator : IIdentityNamesFileOperator
    {
        #region Infrastructure

        public static IIdentityNamesFileOperator Instance { get; } = new IdentityNamesFileOperator();


        private IdentityNamesFileOperator()
        {
        }

        #endregion
    }
}
