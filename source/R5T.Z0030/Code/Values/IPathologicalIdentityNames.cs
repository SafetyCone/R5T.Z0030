using System;

using R5T.T0131;
using R5T.T0162;


namespace R5T.Z0030
{
    /// <summary>
    /// Provides identity name values that are either invalid, ambiguous, or exceptional.
    /// </summary>
    [ValuesMarker]
    public partial interface IPathologicalIdentityNames : IValuesMarker
    {
        public IIdentityName Null => Instances.StringOperator_Extensions.ToIdentityName(null);
        public IIdentityName Empty => Instances.StringOperator_Extensions.ToIdentityName("");
        /// <summary>
        /// Has a valid kind-marker, but lacks the kind-marker separator (and any following namespaced type name).
        /// </summary>
        public IIdentityName TooShort => Instances.StringOperator_Extensions.ToIdentityName("T");
        /// <summary>
        /// Has a valid kind-marker, and a following namespaced type name, but the namespaced type name is not separated from the kind-marker by a kind-marker separator.
        /// </summary>
        public IIdentityName Without_KindMarkerSeparator => Instances.StringOperator_Extensions.ToIdentityName("TSystem.String");

        /// <summary>
        /// Has kind-marker separator and following namespaced type name, but the kind-marker itself is not one of the valid kind-marker values.
        /// </summary>
        public IIdentityName Invalid_KindMarker => Instances.StringOperator_Extensions.ToIdentityName("S:System.String");
    }
}
