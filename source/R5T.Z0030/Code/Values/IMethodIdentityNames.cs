using System;

using R5T.T0131;
using R5T.T0143;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IMethodIdentityNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IMethodIdentityNames _Raw => Raw.MethodIdentityNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public IMethodIdentityName BasicMethod => _Raw.Method001;

        public IMethodIdentityName BasicMethod_OnGenericType => _Raw.Method103;

        public IMethodIdentityName GenericMethod => _Raw.Method003;

        public IMethodIdentityName GenericMethod_OnGenericType => _Raw.Method206;
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
        public IMethodIdentityName Method001 => "M:R5T.T0140.ExampleMethods.Method001".ToMethodIdentityName();

        /// <summary>
        /// A generic method on a basic type, taking an argument of the method's generic type.
        /// </summary>
        public IMethodIdentityName Method003 => "M:R5T.T0140.ExampleMethods.Method003``1(``0)".ToMethodIdentityName();

        /// <summary>
        /// A basic method on a generic type, taking an argument of the type's generic type.
        /// </summary>
        public IMethodIdentityName Method103 => "M:R5T.T0140.ExampleMethods`1.Method103(`0)".ToMethodIdentityName();

        /// <summary>
        /// <para>"M:Microsoft.AspNetCore.Http.Features.FeatureReferences`1.Fetch``1(``0@,System.Func{Microsoft.AspNetCore.Http.Features.IFeatureCollection,``0})"</para>
        /// A generic method on a generic type, with a ref parameter and a generic parameter.
        /// </summary>
        public IMethodIdentityName N_004 => "M:Microsoft.AspNetCore.Http.Features.FeatureReferences`1.Fetch``1(``0@,System.Func{Microsoft.AspNetCore.Http.Features.IFeatureCollection,``0})".ToMethodIdentityName();

        /// <summary>
        /// <para>"M:AnyOneOne.Database.IServiceActionExtensions.AddAnomalyEventRepositoryAction``1(R5T.T0062.IServiceAction)"</para>
        /// </summary>
        public IMethodIdentityName N_005 => "M:AnyOneOne.Database.IServiceActionExtensions.AddAnomalyEventRepositoryAction``1(R5T.T0062.IServiceAction)".ToMethodIdentityName();

        /// <summary>
        /// A generic method on a generic type, taking arguments of both the type's and the method's generic type, and a string.
        /// </summary>
        public IMethodIdentityName Method206 => "M:R5T.T0140.ExampleMethods`1.Method206``1(`0,``0,System.String)".ToMethodIdentityName();
    }
}
