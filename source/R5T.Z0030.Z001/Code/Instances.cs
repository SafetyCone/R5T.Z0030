using System;


namespace R5T.Z0030.Z001
{
    public static class Instances
    {
        public static F0000.IFileOperator FileOperator => F0000.FileOperator.Instance;
        public static Z0039.IFilePaths FilePaths => Z0039.FilePaths.Instance;
        public static IIdentityNamesFileOperator IdentityNamesFileOperator => Z001.IdentityNamesFileOperator.Instance;
    }
}