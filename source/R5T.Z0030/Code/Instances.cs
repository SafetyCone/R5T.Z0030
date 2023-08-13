using System;


namespace R5T.Z0030
{
    public static class Instances
    {
        public static IErrors Errors => Z0030.Errors.Instance;
        public static INamespaceIdentityNames NamespaceIdentityNames => Z0030.NamespaceIdentityNames.Instance;
        public static IPathologicalIdentityNames PathologicalIdentityNames => Z0030.PathologicalIdentityNames.Instance;
        public static T0162.Extensions.IStringOperator StringOperator_Extensions => T0162.Extensions.StringOperator.Instance;
        public static ITypeIdentityNames TypeIdentityNames => Z0030.TypeIdentityNames.Instance;
    }
}