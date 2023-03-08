using System;

using R5T.T0131;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IMethodIdentityNames : IValuesMarker
    {
        private static Raw.IMethodIdentityNames RawMethodIdentityNames => Raw.MethodIdentityNames.Instance;


        public MethodIdentityName BasicMethod => RawMethodIdentityNames.Method001;

        public MethodIdentityName BasicMethod_OnGenericType => RawMethodIdentityNames.Method103;

        public MethodIdentityName GenericMethod => RawMethodIdentityNames.Method003;

        public MethodIdentityName GenericMethod_OnGenericType => RawMethodIdentityNames.Method206;
    }
}


namespace R5T.Z0030.Raw
{
    [ValuesMarker]
    public partial interface IMethodIdentityNames : IValuesMarker
    {
        /// <summary>
        /// A basic method on a basic type.
        /// </summary>
        public MethodIdentityName Method001 => "M:R5T.T0140.ExampleMethods.Method001".ToMethodIdentityName();

        /// <summary>
        /// A generic method on a basic type, taking an argument of the method's generic type.
        /// </summary>
        public MethodIdentityName Method003 => "M:R5T.T0140.ExampleMethods.Method003``1(``0)".ToMethodIdentityName();

        /// <summary>
        /// A basic method on a generic type, taking an argument of the type's generic type.
        /// </summary>
        public MethodIdentityName Method103 => "M:R5T.T0140.ExampleMethods`1.Method103(`0)".ToMethodIdentityName();

        /// <summary>
        /// A generic method on a generic type, taking arguments of both the type's and the method's generic type, and a string.
        /// </summary>
        public MethodIdentityName Method206 => "M:R5T.T0140.ExampleMethods`1.Method206``1(`0,``0,System.String)".ToMethodIdentityName();
    }
}
